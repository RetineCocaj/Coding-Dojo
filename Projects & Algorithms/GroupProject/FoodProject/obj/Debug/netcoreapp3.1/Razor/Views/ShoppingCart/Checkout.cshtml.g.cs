#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fad7d7077945f3676195d657fab11c8b480b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Checkout), @"mvc.1.0.view", @"/Views/ShoppingCart/Checkout.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\_ViewImports.cshtml"
using FoodProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\_ViewImports.cshtml"
using FoodProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fad7d7077945f3676195d657fab11c8b480b3b", @"/Views/ShoppingCart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodProject.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Checkout</h2>\n\n");
#nullable restore
#line 9 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\n            <h4>Complete your Order</h4>\n            <hr />\n            ");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        \n\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 20 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
           Write(Html.LabelFor(model => model.Destination, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <div class=\"col-md-10\">\n                    ");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
               Write(Html.EditorFor(model => model.Destination, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
               Write(Html.ValidationMessageFor(model => model.Destination, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-10"">
                    <input type=""submit"" value=""Save"" class=""btn btn-light"" />
                </div>
            </div>
            
        </div>
");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <p class=\"text-danger ml-3\">");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
                           Write(TempData["Empty Cart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    ");
#nullable restore
#line 38 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\ShoppingCart\Checkout.cshtml"
Write(Html.ActionLink("Go to Cart", "Details", null,null,new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodProject.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
