#pragma checksum "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23c7e168121cac79463956f693e80e03e40fe6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\_ViewImports.cshtml"
using Book_Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\_ViewImports.cshtml"
using Book_Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23c7e168121cac79463956f693e80e03e40fe6e", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21819b486bd78a813b0aa770bfdcba17dc7b4b0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo_Dall7.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .button {
        display: inline-block;
        border-radius: 4px;
        background-color: midnightblue;
        border: none;
        color: #FFFFFF;
        text-align: center;
        font-size: 28px;
        padding: 20px;
        width: 200px;
        transition: all 0.5s;
        cursor: pointer;
        margin: 5px;
    }

        .button span {
            cursor: pointer;
            display: inline-block;
            position: relative;
            transition: 0.5s;
        }

            .button span:after {
                content: '\00bb';
                position: absolute;
                opacity: 0;
                top: 0;
                right: -20px;
                transition: 0.5s;
            }

        .button:hover span {
            padding-right: 25px;
        }

            .button:hover span:after {
                opacity: 1;
                right: 0;
            }
</style>
<h1>Details</h1>

<div>
    <h4>Book</h4>
    <h");
            WriteLiteral("r />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LikeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd class=\"col-sm-10\">\r\n         ");
#nullable restore
#line 64 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
    Write(Html.DisplayFor(model => model.LikeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Abstract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Abstract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n</div>\r\n<button class=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1788, "\"", 1820, 3);
            WriteAttributeValue("", 1798, "AddLike(", 1798, 8, true);
#nullable restore
#line 76 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
WriteAttributeValue("", 1806, Model.BookId, 1806, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1819, ")", 1819, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"vertical-align:middle;font-size:24px \"><span>like ❤ </span> </button>\r\n<button class=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1922, "\"", 1955, 4);
            WriteAttributeValue("", 1932, "DisLike(", 1932, 8, true);
#nullable restore
#line 77 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
WriteAttributeValue("", 1940, Model.BookId, 1940, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1953, ")", 1953, 1, true);
            WriteAttributeValue(" ", 1954, "", 1955, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"vertical-align:middle\"><span>dislike 💔 </span></button>\r\n<br />\r\n<hr />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23c7e168121cac79463956f693e80e03e40fe6e8159", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
                           WriteLiteral(Model.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23c7e168121cac79463956f693e80e03e40fe6e10297", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n   \r\n    function AddLike(bookId) {\r\n        var request = new XMLHttpRequest();\r\n        request.open(\'post\', \'");
#nullable restore
#line 89 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
                         Write(Url.Action("LikeThis"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + bookId);
      
        request.onreadystatechange = function () {
            if (request.readyState == 4 && this.status == 200) {
                document.getElementById('count').value = this.responseText;
               
            }
        }

        request.send();
    }
      function DisLike(bookId) {
        var request = new XMLHttpRequest();
          request.open('post', '");
#nullable restore
#line 102 "C:\Users\Narges\source\repos\Home7\Book_Home\Views\Books\Details.cshtml"
                           Write(Url.Action("UnlikeThis"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + bookId);

          request.onreadystatechange = function () {
            if (request.readyState == 4 && this.status == 200) {
               
                if (response.statut == ""Complete"")
                {
                    $(""#updateBar"").slideDown();

                }

                if (request.response == 0) {
                    document.getElementById(bookId).innerHTML = ""❤ "";
                }
                else {
                   
                    document.getElementById(bookId).innerHTML = ""💔"";
                   
                }
            }
        }

        request.send();
    }
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_Dall7.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
