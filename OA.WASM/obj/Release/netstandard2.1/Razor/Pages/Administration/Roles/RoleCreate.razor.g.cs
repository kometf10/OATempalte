#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542338b0bee97093a683abc8ee79269b1208a3e2"
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
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
           [Authorize(Policy = "administration-roles")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles/create")]
    public partial class RoleCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                          Localizer["Add"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                            Localizer["Role"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                 Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                      HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row mt-3");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(16);
                __builder2.AddAttribute(17, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                                       () => Role.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Label", "Name");
                __builder2.AddAttribute(19, "Id", "Role");
                __builder2.AddAttribute(20, "Active", "active");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                     Role.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Role.Name = __value, Role.Name))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Role.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "m-3");
                __builder2.AddContent(27, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                       Localizer["Select"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(28, " ");
                __builder2.AddContent(29, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                            Localizer["Permissions"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group row mt-3");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-10");
                __Blazor.OA.WASM.Pages.Administration.Roles.RoleCreate.TypeInference.CreateCheckBoxList_0(__builder2, 35, 36, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                                             SelectedPermissions

#line default
#line hidden
#nullable disable
                , 37, "Name", 38, "Value", 39, (__value) => {
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                PermissionsChecks = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group row mt-5");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-sm-5");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "type", "submit");
                __builder2.AddAttribute(47, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(48, 
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                                                          Localizer["Create"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
             if (CreateBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(52);
                __builder2.AddAttribute(53, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "class", "btn btn-comp-s btn-sm");
            __builder.AddAttribute(57, "href", "/roles");
            __builder.AddContent(58, 
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                                                 Localizer["Back to list"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(60);
            __builder.AddAttribute(61, "Title", "Validation Errors");
            __builder.AddComponentReferenceCapture(62, (__value) => {
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Roles\RoleCreate.razor"
                        ServerValidation = (ComponentLib.ServerValidation)__value;

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
namespace __Blazor.OA.WASM.Pages.Administration.Roles.RoleCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCheckBoxList_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<T, global::System.Boolean> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Action<global::ComponentLib.CheckBoxList<T>> __arg3)
        {
        __builder.OpenComponent<global::ComponentLib.CheckBoxList<T>>(seq);
        __builder.AddAttribute(__seq0, "Selected", __arg0);
        __builder.AddAttribute(__seq1, "NameField", __arg1);
        __builder.AddAttribute(__seq2, "ValueField", __arg2);
        __builder.AddComponentReferenceCapture(__seq3, (__value) => { __arg3((global::ComponentLib.CheckBoxList<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
