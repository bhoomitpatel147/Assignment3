#pragma checksum "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9d3eb9362194732e6b89b078c9bcec7fce80dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AssignmentSample.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AssignmentSample.Pages
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
#line 1 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/_ViewImports.cshtml"
using AssignmentSample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9d3eb9362194732e6b89b078c9bcec7fce80dc", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2aa1141ea4087712afe988431f0d6a85d29df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

    
    var content = new [] {
        new {
            title = "Alex",
            type = "Part-Time Instructor",
            body = "Has been teaching for 3 years",
            tag = "javascript"
        },
        new {
            title = "Andrew",
            type = "Coordinator",
            body = "Provided the lecture notes for this class",
            tag = "metal"
        },
        new {
            title = "Phil",
            type = "Coordinator",
            body = "Has the best shirts",
            tag = "tall"
        },
        new {
            title = "Darren",
            type = "Full Time Professor",
            body = "Very skilled at iOS development",
            tag = "mac"
        },
        new {
            title = "Nick",
            type = "Full Time Professor",
            body = "Knows more about php than anyone",
            tag = "laravel"
        }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
 for(var i = 0; i < content.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <h3 class=\"card-header\">");
#nullable restore
#line 44 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
                           Write(content[i].title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"card-body\">");
#nullable restore
#line 45 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
                        Write(content[i].body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"type\">");
#nullable restore
#line 46 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
                     Write(content[i].type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"tag\">");
#nullable restore
#line 47 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
                    Write(content[i].tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 49 "/Users/kevinmitnick/Desktop/AssignmentSample-2/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
