#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b5b0ba96ba321b086045deff76b80686a2a67a0"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Administration.Roles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
           [Authorize(Policy = "administration-roles")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class RolesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
 if (Roles == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "position:relative; height:40px");
            __builder.AddAttribute(3, "class", "mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-title filter-title");
            __builder.AddContent(6, 
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                               Localizer["Roles"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter-link");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(10);
            __builder.AddAttribute(11, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(12, "IconClassList", "fas fa-plus");
            __builder.AddAttribute(13, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("/roles/create") 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __Blazor.OA.WASM.Pages.Administration.Roles.RolesList.TypeInference.CreateGrid_0(__builder, 14, 15, 
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                 Roles

#line default
#line hidden
#nullable disable
            , 16, (__builder2) => {
                __builder2.OpenElement(17, "th");
                __builder2.AddContent(18, 
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                  Localizer["Role"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "th");
                __builder2.AddContent(21, 
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                  Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            , 22, (context) => (__builder2) => {
                __builder2.OpenElement(23, "td");
                __builder2.OpenElement(24, "span");
                __builder2.AddContent(25, 
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                         Localizer["Role"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(26, "  ");
                __builder2.AddContent(27, 
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                                     context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "td");
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                 if (context.Id == "static-role-1-admin")
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.Controls.IconBtn>(30);
                __builder2.AddAttribute(31, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
                __builder2.AddAttribute(32, "IconClassList", "fas fa-lock");
                __builder2.CloseComponent();
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(33);
                __builder2.AddAttribute(34, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                                 () => NavigationManager.NavigateTo("/roles/edit/" + context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                                   () => DeleteRole(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Confirm>(36);
            __builder.AddAttribute(37, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(39, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(40, (__value) => {
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RolesList.razor"
                                                       Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Administration.Roles.RolesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::ComponentLib.Grid<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "GridHeader", __arg1);
        __builder.AddAttribute(__seq2, "GridRow", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
