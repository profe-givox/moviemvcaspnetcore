#pragma checksum "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab953ea37700bed92c7aa9b072143ca0c5c8f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
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
#line 1 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
using MvcMovie.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab953ea37700bed92c7aa9b072143ca0c5c8f54", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.ViewModels.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 5 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n<h2>Index</h2>\r\n\r\n<p>Hello from our View Template!</p>\r\n\r\n<h2>Contact Model Tipado</h2>\r\n<address>\r\n    ");
#nullable restore
#line 13 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(Model.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    ");
#nullable restore
#line 14 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 14 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
            Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
                         Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <abbr title=\"Phone\">P:</abbr> 425.555.0100\r\n</address>\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
  
    // Since Address isn't a string, it requires a cast.
    var address = ViewData["Address"] as Address;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Contact  ViewData </h2>\r\n<address>\r\n    ");
#nullable restore
#line 26 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(address.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    ");
#nullable restore
#line 27 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    ");
#nullable restore
#line 28 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
Write(address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 28 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
              Write(address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\DS4\Code\dotnet\web\MvcMovie\Views\HelloWorld\Index.cshtml"
                             Write(address.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</address>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.ViewModels.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
