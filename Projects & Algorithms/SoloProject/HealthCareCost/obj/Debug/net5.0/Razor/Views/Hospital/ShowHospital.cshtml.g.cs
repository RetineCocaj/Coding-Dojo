#pragma checksum "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b8f8c8d1421d5b642bc8626ee0eaa6e36d8645a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospital_ShowHospital), @"mvc.1.0.view", @"/Views/Hospital/ShowHospital.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\_ViewImports.cshtml"
using HealthCareCost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\_ViewImports.cshtml"
using HealthCareCost.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8f8c8d1421d5b642bc8626ee0eaa6e36d8645a", @"/Views/Hospital/ShowHospital.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a46f97cadb6851c6347282fb644937cd195217", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospital_ShowHospital : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"mb-5 ml-2\" style=\"color:#199CA6;\">");
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h4 class=\" ml-2\">Medical Services</h4>\r\n<ul class=\"list-group col-6 mb-3\">\r\n");
#nullable restore
#line 5 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
     foreach (var item in ViewBag.HospitalMedicalProcedures)
    {
        if(item.HospitalId == Model.HospitalId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item mb-2\">");
#nullable restore
#line 9 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
                                        Write(item.MedicalProcedure.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<h4 class=\" ml-2\">Contact</h4>\r\n<ul class=\"list-group col-6\">\r\n    <li class=\"list-group-item mb-2\">");
#nullable restore
#line 15 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n    <li class=\"list-group-item mb-2\">");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
                                Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n    <li class=\"list-group-item mb-2\">");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
                                Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n");
#nullable restore
#line 18 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
     if(@Model.Website != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item mb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 713, "\"", 734, 1);
#nullable restore
#line 20 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
WriteAttributeValue("", 720, Model.Website, 720, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Go to Website</a></li> \r\n");
#nullable restore
#line 21 "C:\Users\Asus\Desktop\Coding-Dojo\Projects & Algorithms\HealthCareCost\Views\Hospital\ShowHospital.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital> Html { get; private set; }
    }
}
#pragma warning restore 1591
