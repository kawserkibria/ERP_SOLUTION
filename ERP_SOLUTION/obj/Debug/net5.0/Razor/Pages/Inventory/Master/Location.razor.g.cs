#pragma checksum "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\Pages\Inventory\Master\Location.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c551403bbfbb67a9130ed8df6ab5acf5593b8911406beafe65fea95ae5ec0fe7"
// <auto-generated/>
#pragma warning disable 1591
namespace ERP_SOLUTION.Pages.Inventory.Master
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\_Imports.razor"
using ERP_SOLUTION.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\Pages\Inventory\Master\Location.razor"
      "/Location"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Location : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\"><div class=\"row\"><div class=\"col-sm-6\"><div class=\"card\"><div class=\"card-header\" style=\"text-align:center\"><h4>Location/Section</h4></div>\r\n\r\n                <form class=\"form-horizontal\" asp-action=\"Create\"><div class=\"card-body\"><div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n\r\n                        <div class=\"form-group\"><label for=\"exampleInputEmail1\">Location/Section Name :</label>\r\n                            <input asp-for=\"SupplierName\" class=\"form-control\"></div>\r\n                        <div class=\"form-group\"><label for=\"exampleInputEmail1\">Branch :</label>\r\n                            <input asp-for=\"SupplierName\" class=\"form-control\"></div>\r\n                        <div class=\"form-group\"><label for=\"exampleInputEmail1\">Address :</label>\r\n                            <input asp-for=\"SupplierName\" class=\"form-control\"></div>\r\n                        <div class=\"form-group\"><label for=\"exampleInputEmail1\">Phone :</label>\r\n                            <input asp-for=\"SupplierName\" class=\"form-control\"></div>\r\n\r\n                        <div class=\"form-check form-check-inline\"><input class=\"form-check-input\" type=\"checkbox\" id=\"inlineCheckbox1\" value=\"option1\">\r\n                            <label class=\"form-check-label\" for=\"inlineCheckbox1\">Section Hide</label></div>\r\n                        <div class=\"form-check form-check-inline\"><input class=\"form-check-input\" type=\"checkbox\" id=\"inlineCheckbox2\" value=\"option2\">\r\n                            <label class=\"form-check-label\" for=\"inlineCheckbox2\">Active</label></div></div>\r\n                    <div class=\"card-footer\"><div style=\"float:right;padding:10px\"><button class=\"btn btn-sm btn-primary\" type=\"submit\"><i class=\"fa fa-dot-circle-o\"></i> Save\r\n                            </button>\r\n                            <button class=\"btn btn-sm btn-danger\"><i class=\"fa fa-close\"></i> Close\r\n                            </button></div></div></form></div></div>\r\n        <div class=\"col-lg-6\"><div class=\"card\"><div class=\"card-header\"><i class=\"fa fa-align-justify\"></i> Location List\r\n                </div>\r\n                <div class=\"card-body\"><table class=\"table\" id=\"demoGrid\"><thead><tr><th>Location Name</th>\r\n                                <th>Branch Name</th>\r\n                                <th>Status</th>\r\n                                <th></th></tr></thead>\r\n                        <tbody><tr><td>Accounts(Factory)</td>\r\n                                <td>Deeplaid....</td>\r\n                                <td>Active</td>\r\n                                <td><button class=\"btn btn-success btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\"><i class=\"fa fa-edit\"></i></button>\r\n                                    <button class=\"btn btn-danger btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\"><i class=\"fa fa-trash\"></i></button></td></tr></tbody></table></div></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
