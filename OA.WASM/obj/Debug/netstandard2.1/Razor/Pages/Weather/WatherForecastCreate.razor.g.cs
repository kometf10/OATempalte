#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a39c5b33baaae02bfd1be91560eeae4a1e2bc3"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Weather
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather/create")]
    public partial class WatherForecastCreate : WatherForecastCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                          Localizer["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                               Localizer["Weather Forcast"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-sm-10");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<ComponentLib.Controls.MInputNumber>(21);
                __builder2.AddAttribute(22, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                       () => EntityItem.TemperatureC

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Id", "Tempreature");
                __builder2.AddAttribute(24, "Label", "Temperature C");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                       EntityItem.TemperatureC

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.TemperatureC = __value, EntityItem.TemperatureC))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(() => EntityItem.TemperatureC));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group row");
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-10");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDate>(37);
                __builder2.AddAttribute(38, "Type", "date");
                __builder2.AddAttribute(39, "Init", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime>>>(
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                                     () => EntityItem.Date

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Id", "Date");
                __builder2.AddAttribute(42, "Label", "Date");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                             EntityItem.Date

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Date = __value, EntityItem.Date))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime>>>(() => EntityItem.Date));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group row");
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-sm-10");
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(55);
                __builder2.AddAttribute(56, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 22 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                 ()=> EntityItem.Summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Label", "Summary");
                __builder2.AddAttribute(58, "Id", "Summary");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                      EntityItem.Summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Summary = __value, EntityItem.Summary))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EntityItem.Summary));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-md-10");
                __builder2.AddMarkupContent(70, "\r\n            ");
                __Blazor.OA.WASM.Pages.Weather.WatherForecastCreate.TypeInference.CreateMInputSelect_0(__builder2, 71, 72, 
#nullable restore
#line 28 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                   CityItems

#line default
#line hidden
#nullable disable
                , 73, 
#nullable restore
#line 28 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                                     ()=> EntityItem.CityId

#line default
#line hidden
#nullable disable
                , 74, "CityId", 75, "City", 76, 
#nullable restore
#line 28 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                        EntityItem.CityId

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.CityId = __value, EntityItem.CityId)), 78, () => EntityItem.CityId);
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row mt-5");
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-sm-5");
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "type", "submit");
                __builder2.AddAttribute(90, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(91, " ");
                __builder2.AddContent(92, 
#nullable restore
#line 34 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                                          Localizer["Create"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(93, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "         \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-sm-1 pt-1 text-center");
                __builder2.AddMarkupContent(98, "\r\n");
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
             if (CreateBusy) {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(99);
                __builder2.AddAttribute(100, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                         }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(101, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n\r\n");
            __builder.OpenElement(105, "a");
            __builder.AddAttribute(106, "class", "btn btn-comp-s btn-sm");
            __builder.AddAttribute(107, "href", "/wather");
            __builder.AddContent(108, " ");
            __builder.AddContent(109, 
#nullable restore
#line 42 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Weather\WatherForecastCreate.razor"
                                                  Localizer["Back to list"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(110, " ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Weather.WatherForecastCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMInputSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg6)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Label", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
