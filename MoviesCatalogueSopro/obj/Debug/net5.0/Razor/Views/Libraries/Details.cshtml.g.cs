#pragma checksum "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880a6fd9ee18810025f71fda0bf0a52947c3acb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libraries_Details), @"mvc.1.0.view", @"/Views/Libraries/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\_ViewImports.cshtml"
using MoviesCatalogueSopro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\_ViewImports.cshtml"
using MoviesCatalogueSopro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880a6fd9ee18810025f71fda0bf0a52947c3acb1", @"/Views/Libraries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4971323eb4a3a28693de4481607c0697482928fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Libraries_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesCatalogueSopro.Models.Library>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
  
    ViewData["Title"] = "Details Of Libraries";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details Of Libraries</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"listButtonDetails\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "880a6fd9ee18810025f71fda0bf0a52947c3acb14488", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<h2>List of movies: </h2>\r\n<ul>\r\n");
#nullable restore
#line 26 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
     foreach (var item in Model.movies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 592, "\"", 623, 2);
            WriteAttributeValue("", 599, "/Movies/Details/", 599, 16, true);
#nullable restore
#line 29 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
WriteAttributeValue("", 615, item.Id, 615, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 31 "C:\Projects\MoviesCatalogueSopro\MoviesCatalogueSopro\Views\Libraries\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesCatalogueSopro.Models.Library> Html { get; private set; }
    }
}
#pragma warning restore 1591
