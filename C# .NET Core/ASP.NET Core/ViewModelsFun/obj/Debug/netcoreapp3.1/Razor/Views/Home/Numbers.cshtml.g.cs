#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b829aaa1ed713ecde6aef1456238779b5be8346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\_ViewImports.cshtml"
using ViewModelsFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b829aaa1ed713ecde6aef1456238779b5be8346", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81a75cfaf1d772b53b0c424a0286222e9a36db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Here are some numbers!</h3>\r\n<div class=\"border border-dark w-25 px-3 py-2\">\r\n");
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\Numbers.cshtml"
     foreach(var num in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\Numbers.cshtml"
      Write(num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\Asus\Desktop\Coding-Dojo\C# .NET Core\ASP.NET Core\ViewModelsFun\Views\Home\Numbers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
