#pragma checksum "C:\temp\VB\WebExample\WebExample\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327da5f353a6f51cf5708412ed9839b934748360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\temp\VB\WebExample\WebExample\Views\_ViewImports.cshtml"
using WebExample;

#line default
#line hidden
#line 2 "C:\temp\VB\WebExample\WebExample\Views\_ViewImports.cshtml"
using WebExample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327da5f353a6f51cf5708412ed9839b934748360", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21f00a1229ec598da07e323f8db7284f027acf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12, true);
            WriteLiteral("<h1><strong>");
            EndContext();
            BeginContext(13, 19, false);
#line 1 "C:\temp\VB\WebExample\WebExample\Views\Home\Contact.cshtml"
       Write(ViewData["Creator"]);

#line default
#line hidden
            EndContext();
            BeginContext(32, 21, true);
            WriteLiteral(" </strong></h1>\r\n<h4>");
            EndContext();
            BeginContext(54, 23, false);
#line 2 "C:\temp\VB\WebExample\WebExample\Views\Home\Contact.cshtml"
Write(ViewData["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(77, 362, true);
            WriteLiteral(@"</h4>


<address>
    <abbr title=""Whatsapp"">Contact: </abbr>
    (12) 98183-6470
</address>

<address>
    <strong> GitHub: <a href=""https://github.com/joonesgarcia""> github.com/joonesgarcia </a></strong> <br />
    <strong> LinkedIn: <a href=""https://www.linkedin.com/in/jo%C3%A3o-garcia-768740140""> linkedin.com/joão-garcia </a></strong>
</address>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
