#pragma checksum "E:\MyProject\C#\NETCore\Demo\Demo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a01adccd625549921cd6516ac6fffe3ee4bb7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\MyProject\C#\NETCore\Demo\Demo\Views\_ViewImports.cshtml"
using Demo.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a01adccd625549921cd6516ac6fffe3ee4bb7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9e52c6a73892ebc8663d031ba3885d87c907a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 18, true);
            WriteLiteral("<h2>Index</h2>\r\n\r\n");
            EndContext();
#line 4 "E:\MyProject\C#\NETCore\Demo\Demo\Views\Home\Index.cshtml"
 foreach(User user in Model)
{

#line default
#line hidden
            BeginContext(70, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(78, 7, false);
#line 6 "E:\MyProject\C#\NETCore\Demo\Demo\Views\Home\Index.cshtml"
  Write(user.ID);

#line default
#line hidden
            EndContext();
            BeginContext(85, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(88, 9, false);
#line 6 "E:\MyProject\C#\NETCore\Demo\Demo\Views\Home\Index.cshtml"
            Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "E:\MyProject\C#\NETCore\Demo\Demo\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
