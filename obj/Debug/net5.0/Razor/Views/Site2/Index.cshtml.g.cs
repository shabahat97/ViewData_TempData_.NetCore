#pragma checksum "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\Site2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fa9c5cfb753d5ff0091e6c4f148086f04b4d4e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site2_Index), @"mvc.1.0.view", @"/Views/Site2/Index.cshtml")]
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
#line 1 "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\_ViewImports.cshtml"
using ViewData_TempData_.Net_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\_ViewImports.cshtml"
using ViewData_TempData_.Net_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa9c5cfb753d5ff0091e6c4f148086f04b4d4e8", @"/Views/Site2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04ce45d5f46a33186f2a7d1c50bb0a6faff6bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Site2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\Site2\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    Name:");
#nullable restore
#line 9 "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\Site2\Index.cshtml"
    Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    City:");
#nullable restore
#line 12 "C:\Users\PC-003\source\repos\ViewData_TempData-.Net Core\Views\Site2\Index.cshtml"
    Write(TempData["City"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591