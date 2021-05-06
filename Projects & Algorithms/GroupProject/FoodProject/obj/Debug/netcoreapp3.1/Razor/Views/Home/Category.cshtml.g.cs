#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a439a5a55b82ec324828eab6bd3c4258561ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
using FoodProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a439a5a55b82ec324828eab6bd3c4258561ca4", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
  
    ViewData["Title"] = "Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class =\"d-flex justify-content-between align-items-end\">\n    <h2>Categories\n");
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
     if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
   Write(Html.ActionLink("", "Add", "Category", new { returnUrl = @Url.Action() }, new { @class = "text-light", @id="addCategoryBtn"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                                                                                      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h2>\n</div>\n\n\n<table class=\"table category-table\">\n    <tr>\n        <th>Name</th>\n        <th class=\"text-center\">Number of Food Items</th>\n        <th class=\"text-center\">Category Actions</th>\n\n    </tr>\n\n");
#nullable restore
#line 27 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
     foreach (Category item in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 804, "\"", 870, 2);
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
WriteAttributeValue("", 812, item.CategoryId == ViewBag.CategoryId ? "selected": "", 812, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 869, "", 870, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td class=\"text-center\">\n                ");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
           Write(item.FoodItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td class=\"text-center\">\n                ");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
           Write(Html.ActionLink("Show", "Category", null, null, null, "selectedFoodTable", new { categoryId = item.CategoryId }, new { @class = "btn btn-success", @id="showBtn"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 38 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                 if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Category", new { categoryId = item.CategoryId, returnUrl = Url.Action() }, new { @class = "btn btn-primary mr-2" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
               Write(Html.ActionLink("Remove", "Remove", "Category", new { categoryId = item.CategoryId, returnUrl = Url.Action() }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                                                                                                                       
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 45 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n\n");
#nullable restore
#line 50 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
 if (ViewBag.CategoryId != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex justify-content-between align-items-end flex-wrap px-4 py-2\">\n    <h4>All Food items in Selected Category\n");
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
         if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
       Write(Html.ActionLink("", "AddItem", "Category", new { categoryId = ViewBag.CategoryId, returnUrl = @Url.Action() }, new { @class = "text-light", @id="addItemBtn"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                                                                                                                           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h4>\n    \n    <table class=\"table category-table\" id=\"selectedFoodTable\">\n        <tr>\n            <th>Name</th>\n            <th>Price</th>\n            <th>Cart Actions</th>\n");
#nullable restore
#line 65 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
             if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Item Actions</th>\n");
#nullable restore
#line 68 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
         if (Model.FoodItems.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
             foreach (FoodItem food in Model.FoodItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                   Write(Html.DisplayFor(modelItem => food.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 79 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                   Write(Html.DisplayFor(modelItem => food.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 82 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                         if (food.isEnabled == true)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                       Write(Html.ActionLink("Add To Cart", "Buy", new { id = food.FoodItemId, returnUrl = Url.Action("Category", new { categoryId = food.CategoryId }) + Html.Raw("#selectedFoodTable") }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                                                                                                                                                                                               
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-success\">Added to Cart</button>\n");
#nullable restore
#line 89 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", "ShoppingCart", new { cartItemId = food.CartItemId, returnUrl = Url.Action("Category", new { categoryId = food.CategoryId }) + Html.Raw("#selectedFoodTable") }, new { @class = "btn btn-primary mr-1" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                                                                                                                                                                                                                      ;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                       Write(Html.ActionLink("Remove", "Remove", "ShoppingCart",
                                new { cartItemId = food.CartItemId, returnUrl = Url.Action("Category", new { categoryId = food.CategoryId }) + Html.Raw("#selectedFoodTable") },
                                new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                                                                  ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n");
#nullable restore
#line 95 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                     if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("class", " class=\"", 4221, "\"", 4229, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 98 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                       Write(Html.ActionLink("Edit", "EditItem", "Category", new { foodItemId = food.FoodItemId, returnUrl = Url.Action() }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 99 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                       Write(Html.ActionLink("Remove", "RemoveItem", "Category", new { foodItemId = food.FoodItemId, returnUrl = Url.Action() }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n");
#nullable restore
#line 101 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 103 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
             
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td colspan=\"3\" class=\"text-center\">This category has no items</td>\n            </tr>\n");
#nullable restore
#line 108 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n    </div>\n");
#nullable restore
#line 111 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\GroupProject\FoodProject\Views\Home\Category.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function(){
        $("".selected td:nth-child(3) a:nth-child(1)"").html(""Showed"");
        $("".selected td:nth-child(3) a:nth-child(1)"").addClass(""disabled"");
        $('#addItemBtn').append('<i class=""fa fa-plus-circle ml-2"" style=""font-size: 18pt;"" title=""Click here to add an Item!""></i>');
        $('#addCategoryBtn').append(' <i class=""fa fa-plus-circle ml-2"" style=""font-size: 22pt;""title=""Click here to add a Category!""></i>');
    });
</script>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
