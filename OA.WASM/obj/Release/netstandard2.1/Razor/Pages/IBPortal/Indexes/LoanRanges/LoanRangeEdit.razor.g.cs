#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f57062891720f67becf1230581ec0553e66e48"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.Indexes.LoanRanges
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
using OA.Domin.IBPortal.LoanProcessWorkFlow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
           [Authorize(Policy = "loan-configs")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoanRange/edit/{id}")]
    public partial class LoanRangeEdit : LoanRangeEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                          Localizer["Edit"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                             Localizer["Loan Range"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __Blazor.OA.WASM.Pages.IBPortal.Indexes.LoanRanges.LoanRangeEdit.TypeInference.CreateInputNumber_0(__builder2, 12, 13, "ID", 14, "hide", 15, 
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                              EntityItem.Id

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Id = __value, EntityItem.Id)), 17, () => EntityItem.Id);
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group row");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(23);
                __builder2.AddAttribute(24, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                             () => EntityItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Id", "Name");
                __builder2.AddAttribute(26, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                                           typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "PropName", "Name");
                __builder2.AddAttribute(28, "Active", "active");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
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
                __builder2.AddAttribute(36, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(37);
                __builder2.AddAttribute(38, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                     () => EntityItem.MinAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Id", "Min");
                __builder2.AddAttribute(40, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                                                       typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "PropName", "MinAmount");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                        EntityItem.MinAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.MinAmount = __value, EntityItem.MinAmount))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.MinAmount));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(48);
                __builder2.AddAttribute(49, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                     () => EntityItem.MaxAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Id", "Max");
                __builder2.AddAttribute(51, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                                                       typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "PropName", "MaxAmount");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                        EntityItem.MaxAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.MaxAmount = __value, EntityItem.MaxAmount))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.MaxAmount));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(61);
                __builder2.AddAttribute(62, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                        () => EntityItem.FileStudyFee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Id", "FileStudyFee");
                __builder2.AddAttribute(64, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                                                                      typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "PropName", "FileStudyFee");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                        EntityItem.FileStudyFee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.FileStudyFee = __value, EntityItem.FileStudyFee))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.FileStudyFee));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group row");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(74);
                __builder2.AddAttribute(75, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                () => EntityItem.CommissionPercentage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "Id", "CommissionPercentage");
                __builder2.AddAttribute(77, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                                                                                                              typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "PropName", "CommissionPercentage");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                        EntityItem.CommissionPercentage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.CommissionPercentage = __value, EntityItem.CommissionPercentage))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.CommissionPercentage));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n    ");
                __builder2.OpenComponent<ComponentLib.Controls.CheckBoxBtn>(83);
                __builder2.AddAttribute(84, "Text", "Group Loan");
                __builder2.AddAttribute(85, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                            EntityItem.GroupLoan

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                              (isgroup) => EntityItem.GroupLoan = isgroup

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n\r\n    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group row mt-5");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-sm-5");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "type", "submit");
                __builder2.AddAttribute(94, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(95, 
#nullable restore
#line 45 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                                          Localizer["Save"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
             if (EditBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(99);
                __builder2.AddAttribute(100, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 49 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n\r\n");
            __builder.OpenElement(102, "a");
            __builder.AddAttribute(103, "class", "btn btn-comp-s btn-sm");
            __builder.AddAttribute(104, "href", "/LoanRanges");
            __builder.AddContent(105, 
#nullable restore
#line 54 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeEdit.razor"
                                                      Localizer["Back to list"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.IBPortal.Indexes.LoanRanges.LoanRangeEdit
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
    }
}
#pragma warning restore 1591
