#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\RandUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c83b4ab634f9fbbc6cd2d76e9dc045be35eb3ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RandUser), @"mvc.1.0.view", @"/Views/Home/RandUser.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\_ViewImports.cshtml"
using ViewModelsFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\RandUser.cshtml"
using ViewModelsFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c83b4ab634f9fbbc6cd2d76e9dc045be35eb3ee", @"/Views/Home/RandUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81a75cfaf1d772b53b0c424a0286222e9a36db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RandUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Here is a User!</h3>\r\n<p class=\"display-1 text-justify mt-5\">");
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\RandUser.cshtml"
                                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\RandUser.cshtml"
                                                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591