#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6be55a2ee79291edefcc8e70775e2fe84e5a0c8"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLib
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, @"
    .paging-container{

    }

    .paging-group{
        position: relative;
    }

    .paging-group .paging-item {
        display: inline-block;
        cursor: pointer;
        min-width: 24px;
        height: 27px;
        padding-left: 5px;
        padding-right: 5px;
        text-align: center;
        background-color: #DDD;
        color: gray;
    }

    .paging-group .disabled{
        cursor: not-allowed;
        pointer-events: none;
    }

    .paging-group .enabled:hover{
        border: 1px solid ");
            __builder.AddContent(2, 
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                           Theme.MainBackground

#line default
#line hidden
            );
            __builder.AddMarkupContent(3, ";\r\n    }\r\n\r\n    .paging-group .active {\r\n        background-color: ");
            __builder.AddContent(4, 
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                           Theme.MainBackground

#line default
#line hidden
            );
            __builder.AddMarkupContent(5, ";\r\n        color: #FFF;\r\n    }\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "paging-container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "paging-group");
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
         foreach (var link in Links)
        {

#line default
#line hidden
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                            () => OnPageSelected(link)

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "class", "btn" + " btn-sm" + " paging-item" + " " + (
#line 44 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                                                  link.Enabled? "enabled": "disabled"

#line default
#line hidden
            ) + " " + (
#line 44 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                                                                                         link.Active? "active": ""

#line default
#line hidden
            ));
            __builder.AddContent(14, 
#line 45 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                 link.Text

#line default
#line hidden
            );
            __builder.CloseElement();
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
        }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mb-5 mt-2");
            __builder.AddContent(18, 
#line 50 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                         Localizer["Total"]

#line default
#line hidden
            );
            __builder.AddContent(19, " : [ ");
            __builder.AddContent(20, 
#line 50 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Pagination.razor"
                                                 PagingData.TotalCount

#line default
#line hidden
            );
            __builder.AddContent(21, " ] ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
