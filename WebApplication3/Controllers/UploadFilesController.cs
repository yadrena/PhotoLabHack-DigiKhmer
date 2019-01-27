using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Net.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UploadFilesController : Controller
    {
        private readonly MvcMovieContext _context;

        public UploadFilesController(MvcMovieContext context)
        {
            _context = context;
        }

        static string c_api_custom_tmplt_endpoint = "http://api-soft.photolab.me/template_process.php";
        static string c_api_photolab_tmplt_endpoint = "http://api-soft.photolab.me/photolab_process.php";
        static string c_api_upload_endpoint = "http://upload-soft.photolab.me/upload.php?no_resize=1";

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {

            int tmpltId = 0;
            if(!string.IsNullOrWhiteSpace(Request.Form["tmpltId"]))
                int.TryParse(Request.Form["tmpltId"], out tmpltId);

            var Templates = new Dictionary<string, string>()
            {
                { "Zombie", "2187" },
            };

            long size = files.Sum(f => f.Length);

            // full path to file in temp location

            
            if(1==files.Count)
            {
                var formFile = files[0];

                var filePath = Path.GetTempFileName() + Path.GetExtension(formFile.FileName);


                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }

                string uploadedImageUrl;

                using (var uploadImageWebClient = new WebClient())
                {
                    byte[] responseArray = uploadImageWebClient.UploadFile(c_api_upload_endpoint, filePath);

                    uploadedImageUrl = Encoding.UTF8.GetString(responseArray);
                }

                string transformedImageUrl;

                using (var httpClient = new HttpClient())
                {
                    var values = new Dictionary<string, string>
                    {
                       { "image_url[1]", uploadedImageUrl },
                       { "template_name", Templates.ToList()[tmpltId].Value }
                    };

                    var content = new FormUrlEncodedContent(values);

                    var response = await httpClient.PostAsync(c_api_photolab_tmplt_endpoint, content);

                    transformedImageUrl = await response.Content.ReadAsStringAsync();
                }

                string bluredImageUrl;

                using (var httpClient = new HttpClient())
                {
                    var values = new Dictionary<string, string>
                    {
                       { "image_url[1]", transformedImageUrl },
                       //{ "template_name", "DD406536-1D2F-B0D4-7D0F-51828625B52D" /* blur1 */ }
                       { "template_name", "BC75E995-B4CF-7854-E165-C734EEC2A775" /* blur2 */ }
                    };

                    var content = new FormUrlEncodedContent(values);

                    var response = await httpClient.PostAsync(c_api_custom_tmplt_endpoint, content);

                    bluredImageUrl = await response.Content.ReadAsStringAsync();
                }


                Muck muck = new Muck
                {
                    AppliedTemplate = Templates.ToList()[tmpltId].Key,
                    AuthorEmail = User.Identity.Name,
                    UploadedImageURL = uploadedImageUrl,
                    ConvertedImageURL = transformedImageUrl,
                    BluredImageURL = bluredImageUrl,
                    Image = System.IO.File.ReadAllBytes(filePath)
                };

                {
                    _context.Muck.Add(muck);

                    _context.SaveChanges();
                }

                return Ok(new { count = files.Count, size, filePath, uploadedImageUrl, transformedImageUrl, bluredImageUrl, insertedId = muck.Id });
            }

            return Ok(new { count = 0} );
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
        }
    }
}