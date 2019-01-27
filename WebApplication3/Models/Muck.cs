using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Muck
    {
        public int Id { get; set; }

        public string AuthorEmail { get; set; }

        public byte[] Image { get; set; }

        public string UploadedImageURL { get; set; }

        public string AppliedTemplate { get; set; }

        public string ConvertedImageURL { get; set; }

        public string BluredImageURL { get; set; }
    }
}
