#pragma checksum "C:\Users\amano\Documents\GitHub\DigiKhmer\WebApplication3\Views\Mucks\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c6bb3776fac1924ba77e5b803b30d953922e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mucks_Quiz), @"mvc.1.0.view", @"/Views/Mucks/Quiz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mucks/Quiz.cshtml", typeof(AspNetCore.Views_Mucks_Quiz))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\amano\Documents\GitHub\DigiKhmer\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\amano\Documents\GitHub\DigiKhmer\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c6bb3776fac1924ba77e5b803b30d953922e90", @"/Views/Mucks/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Mucks_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.Muck>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kulagin_zombie_blured.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\amano\Documents\GitHub\DigiKhmer\WebApplication3\Views\Mucks\Quiz.cshtml"
  
    ViewData["Title"] = "Загадка";

#line default
#line hidden
            BeginContext(81, 199, true);
            WriteLiteral("\r\n<table cellpadding=\"0\" cellspacing=\"0\">\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                <div>\r\n                    <dl class=\"row\">\r\n\r\n                        <dd class=\"col-sm-10\">\r\n");
            EndContext();
            BeginContext(375, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(403, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9c6bb3776fac1924ba77e5b803b30d953922e904567", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(463, 1074, true);
            WriteLiteral(@"
                        </dd>

                        <dd class=""col-sm-10"">
                            &nbsp;
                        </dd>
                    </dl>
                </div>
            </td>
            <td valign=""top"" style=""padding-left:50px;"">
                <h1>ЗАГАДКА — ЧТО ПРОИЗОШЛО?</h1>
                <br/>
                <dl class=""row"" >

                    <dd class=""col-sm-10"">
                        
                        <a style=""width:300px;"" class=""btn btn-primary  btn-lg"" role=""button"" href=""#"">Алкоголь</a>
                    </dd>

                    <dd class=""col-sm-10"">
                        <a style=""width:300px;"" class=""btn btn-primary btn-lg"" role=""button"" href=""/Home/Revenge"">Зомби</a>
                    </dd>

                    <dd class=""col-sm-10"">
                        <a style=""width:300px;"" class=""btn btn-primary btn-lg"" role=""button"" href=""#"">Пауки</a>
                    </dd>
                    </dl>
</td>
   ");
            WriteLiteral("     </tr>\r\n    </tbody>\r\n</table>\r\n            \r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.Muck> Html { get; private set; }
    }
}
#pragma warning restore 1591
