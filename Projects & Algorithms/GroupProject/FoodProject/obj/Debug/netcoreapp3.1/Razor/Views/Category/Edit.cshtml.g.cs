#pragma checksum "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ebe6c7e5267cb73240574df30b7bc337515f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Edit), @"mvc.1.0.view", @"/Views/Category/Edit.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\FoodProject\Views\_ViewImports.cshtml"
using FoodProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\FoodProject\Views\_ViewImports.cshtml"
using FoodProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ebe6c7e5267cb73240574df30b7bc337515f5a", @"/Views/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodProject.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = "Edit Category";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Category</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>");
#nullable restore
#line 14 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
   Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"hidden\" name=\"returnUrl\"");
            BeginWriteAttribute("value", " value=\"", 430, "\"", 451, 1);
#nullable restore
#line 18 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
WriteAttributeValue("", 438, Url.Action(), 438, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-6\">Edit Name</label>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-light\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p class=\"text-danger ml-3\">");
#nullable restore
#line 36 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
                           Write(TempData["SameNameError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\FoodProject\Views\Category\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Category", "Home", null,new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodProject.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591