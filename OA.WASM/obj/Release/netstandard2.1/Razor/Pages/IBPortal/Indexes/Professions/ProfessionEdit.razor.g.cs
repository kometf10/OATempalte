#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719960804527b544713b2bd6d27a8d0861e2851e"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.Indexes.Professions
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
using OA.Domin.IBPortal.Indexes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
           [Authorize(Policy = "indexes-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profession/edit/{id}")]
    public partial class ProfessionEdit : ProfessionEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
     Localizer["Edit"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                        Localizer["Profession"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __Blazor.OA.WASM.Pages.IBPortal.Indexes.Professions.ProfessionEdit.TypeInference.CreateInputNumber_0(__builder2, 12, 13, "ID", 14, "hide", 15, 
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                              EntityItem.Id

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Id = __value, EntityItem.Id)), 17, () => EntityItem.Id);
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group row");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(23);
                __builder2.AddAttribute(24, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                             () => EntityItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Id", "Name");
                __builder2.AddAttribute(26, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                                                           typeof(Profession)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "PropName", "Name");
                __builder2.AddAttribute(28, "Active", "active");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                     EntityItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Name = __value, EntityItem.Name))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EntityItem.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(37);
                __builder2.AddAttribute(38, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                             () => EntityItem.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Id", "Name");
                __builder2.AddAttribute(40, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                                                           typeof(Profession)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "PropName", "Code");
                __builder2.AddAttribute(42, "Active", "active");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                     EntityItem.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Code = __value, EntityItem.Code))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EntityItem.Code));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group row mt-3 mb-5");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-10");
                __Blazor.OA.WASM.Pages.IBPortal.Indexes.Professions.ProfessionEdit.TypeInference.CreateMInputSelect_1(__builder2, 51, 52, 
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                               ProfessionSectorItems

#line default
#line hidden
#nullable disable
                , 53, 
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                                                             ()=> EntityItem.ProfessionSectorId

#line default
#line hidden
#nullable disable
                , 54, "ProfessionSectorId", 55, 
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                                                                                                                                      typeof(Profession)

#line default
#line hidden
#nullable disable
                , 56, "ProfessionSectorId", 57, 
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                        EntityItem.ProfessionSectorId

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.ProfessionSectorId = __value, EntityItem.ProfessionSectorId)), 59, () => EntityItem.ProfessionSectorId);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row mt-5");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-sm-5");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "type", "submit");
                __builder2.AddAttribute(67, "class", "btn btn-comp btn-block btn-sm");
                __builder2.AddContent(68, 
#nullable restore
#line 35 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                                          Localizer["Save"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
             if (EditBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(72);
                __builder2.AddAttribute(73, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 39 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n\r\n");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "href", "/Professions");
            __builder.AddAttribute(77, "class", "btn btn-sm btn-comp-s");
            __builder.AddContent(78, 
#nullable restore
#line 44 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                       Localizer["Back to list"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-sm btn-comp-s");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                DeleteItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                              Localizer["Delete"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(85);
            __builder.AddAttribute(86, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
                                                  ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\Professions\ProfessionEdit.razor"
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
namespace __Blazor.OA.WASM.Pages.IBPortal.Indexes.Professions.ProfessionEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMInputSelect_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg7)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
