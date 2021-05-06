#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497c4d385e0f3cd27a9cd5a8af77b2ccaeca4bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497c4d385e0f3cd27a9cd5a8af77b2ccaeca4bf9", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodProject.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "All Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>All Orders</h2>\n\n\n<table class=\"table category-table\">\n    <tr>\n        <th>\n            Name\n        </th>\n        <th>\n            ");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th class=\"text-center\">\n            Items\n        </th>\n        <th class=\"text-center\">\n            Order Date\n        </th>\n        <th");
            BeginWriteAttribute("class", " class=\"", 436, "\"", 444, 0);
            EndWriteAttribute();
            WriteLiteral(">\n            ");
#nullable restore
#line 25 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th class=\"text-center\">\n            Phone Number\n        </th>\n        <th>Status</th>\n        <th>Action</th>\n    </tr>\n\n");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
     if (Model != null && Model.Count() > 0)
    {
        
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td class=\"text-center\">\n");
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                     foreach (var foodItem in item.Items)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                   Write(Html.Raw(foodItem.Name + " (x" + foodItem.Quantity.ToString() + ")" + "<br />"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                                                                                                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td class=\"text-center\">\n                    ");
#nullable restore
#line 53 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
               Write(item.OrderDate.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n\n                <td");
            BeginWriteAttribute("class", " class=\"", 1421, "\"", 1429, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 57 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td class=\"text-center\">\n                    ");
#nullable restore
#line 60 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n");
#nullable restore
#line 62 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                 if(item.Status == "Pending")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        Pending\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 68 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                   Write(Html.ActionLink("Deliver", "Deliver", new { id = item.OrderId, returnUrl = Url.Action() }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        Delivered\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                   Write(Html.ActionLink("Remove", "Delete", new { id = item.OrderId, returnUrl = Url.Action() }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 78 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 80 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"text-center\"><td colspan=\"8\"><h4>No User has done any Order</h4> </td> </tr>\n");
#nullable restore
#line 85 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Order\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodProject.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
