#pragma checksum "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\Pages\Inventory\Master\StockItem.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c2a001a0bf21e7c54d68c75887da8a7560bf65d47168a9730af72027f357a6d3"
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
#line 1 "C:\Users\Administrator\Desktop\Kawsar\Kawser kibria\ERP_SOLUTION\ERP_SOLUTION\Pages\Inventory\Master\StockItem.razor"
      "/StockItem"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class StockItem : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    form {
        width: 100%;
        /*padding: 20px;*/
    }

    label {
        padding: 0 5px;
        text-align: right;
        vertical-align: middle;
    }

    input {
        /*padding: 5px;*/
        vertical-align: middle;
    }

    .checkbox {
        margin-bottom: 10px;
    }

    select, .children, .gender, .bdate-block {
        /*width: calc(100% + 26px);*/
        width: 72%;
        padding: 5px 0;
    }

    select {
        background: transparent;
    }

    .gender input {
        width: auto;
    }

    .gender label {
        padding: 0 5px 0 0;
    }

    .bdate-block {
        display: flex;
        justify-content: space-between;
    }

    .birthdate select.day {
        width: 35px;
    }

    .birthdate select.mounth {
        width: calc(100% - 94px);
    }

    .birthdate input {
        width: 38px;
        vertical-align: unset;
    }

    .checkbox input, .children input {
        width: auto;
        margin: -2px 10px 0 0;
    }


    label {
        width: 20%;
    }

    input {
        width: 70%;
    }

    .sm-input {
        width: 40%;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "<div class=\"card-header\" style=\"text-align:center\"><h4>Stock Item</h4></div>\r\n\r\n                ");
            __builder.OpenElement(10, "form");
            __builder.AddAttribute(11, "class", "form-horizontal");
            __builder.AddAttribute(12, "asp-action", "Create");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n\r\n\r\n\r\n\r\n                        ");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "<div><label>Apps Branch :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(18, "<div><label>Item Name :</label><input asp-for=\"VoucherName\">\r\n                                <input style=\"width:10px;margin-right:5px\" type=\"checkbox\" name=\"checkbox\"><span>SP Item</span></div>\r\n                            ");
            __builder.AddMarkupContent(19, "<div><label>Item Code :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(20, "<div><label>Item Description :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(21, "<div><label>Power Class :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(22, "<div><label>Under :</label><input asp-for=\"VoucherName\"></div>\r\n\r\n                            ");
            __builder.AddMarkupContent(23, "<div><label>Pack Size :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(24, "<div><label>Material Type :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.AddMarkupContent(25, "<div><label>Unit :</label><input asp-for=\"VoucherName\" class=\"sm-input\">\r\n                                <input style=\"width:20px;margin-right:5px\" type=\"checkbox\" name=\"checkbox\"><span>Maintain alt. Unit</span></div>\r\n                            ");
            __builder.AddMarkupContent(26, "<div><label>Minimum Stock :</label><input asp-for=\"VoucherName\" class=\"sm-input\"></div>\r\n                            ");
            __builder.AddMarkupContent(27, "<div><label>Reorder Quantity :</label><input asp-for=\"VoucherName\" class=\"sm-input\"></div>\r\n                            ");
            __builder.AddMarkupContent(28, "<div><label>Manufacturer :</label><input asp-for=\"VoucherName\"></div>\r\n                            ");
            __builder.OpenElement(29, "div");
            __builder.AddMarkupContent(30, "<label>Maintain Batch :</label>");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "class", "sm-input");
            __builder.OpenElement(33, "option");
            __builder.AddContent(34, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                            ");
            __builder.AddMarkupContent(36, "<div><label>Inactive :</label><input asp-for=\"VoucherName\" class=\"sm-input\"></div>\r\n                            ");
            __builder.AddMarkupContent(37, @"<div style=""margin-left:152px;background-color:lightpink""><label></label>
                                <div class=""form-row""><div class=""form-group col-md-3""><label style=""text-align:left"" for=""inputCity"" class=""col-sm-12 col-form-label"">Opening Qty:</label>
                                        <input type=""text"" style=""width:100%""></div>
                                    <div class=""form-group col-md-3""><label style=""text-align:left"" for=""inputCity"" class=""col-sm-12 col-form-label"">Rate:</label>
                                        <input type=""text"" style=""width:100%""></div>
                                    <div class=""form-group col-md-3""><label style=""text-align:left"" for=""inputCity"" class=""col-sm-12 col-form-label"">Value:</label>
                                        <input type=""text"" style=""width:100%""></div>
                                    <div class=""form-group col-md-3""><label style=""text-align:left"" for=""inputCity"" class=""col-sm-12 col-form-label"">Batch:</label>
                                        <input type=""text"" style=""width:100%""></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddMarkupContent(39, @"<div class=""card-footer""><div style=""float:right;padding:10px""><button class=""btn btn-sm btn-primary"" type=""submit""><i class=""fa fa-dot-circle-o""></i> Save
                            </button>
                            <button class=""btn btn-sm btn-danger""><i class=""fa fa-close""></i> Close
                            </button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __builder.AddMarkupContent(41, "<div><a asp-action=\"Index\">Back to List</a></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
