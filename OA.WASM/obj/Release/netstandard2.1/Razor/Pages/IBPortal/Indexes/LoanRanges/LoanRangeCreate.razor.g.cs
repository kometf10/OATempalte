#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d161eea0845e7caaabcd99473924d2a539b3957b"
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
using OA.Domin.IBPortal.LoanProcessWorkFlow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
           [Authorize(Policy = "loan-configs")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoanRange/create")]
    public partial class LoanRangeCreate : LoanRangeCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                          Localizer["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
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
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(16);
                __builder2.AddAttribute(17, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                             () => EntityItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Id", "Name");
                __builder2.AddAttribute(19, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                                           typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "PropName", "Name");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                     EntityItem.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.Name = __value, EntityItem.Name))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EntityItem.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(29);
                __builder2.AddAttribute(30, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                     () => EntityItem.MinAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Id", "Min");
                __builder2.AddAttribute(32, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                                                       typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "PropName", "MinAmount");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                        EntityItem.MinAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.MinAmount = __value, EntityItem.MinAmount))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.MinAmount));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(40);
                __builder2.AddAttribute(41, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                     () => EntityItem.MaxAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Id", "Max");
                __builder2.AddAttribute(43, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                                                       typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "PropName", "MaxAmount");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                        EntityItem.MaxAmount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.MaxAmount = __value, EntityItem.MaxAmount))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.MaxAmount));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group row");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(53);
                __builder2.AddAttribute(54, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                        () => EntityItem.FileStudyFee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Id", "FileStudyFee");
                __builder2.AddAttribute(56, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                                                                      typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "PropName", "FileStudyFee");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                        EntityItem.FileStudyFee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.FileStudyFee = __value, EntityItem.FileStudyFee))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.FileStudyFee));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputDecimal>(66);
                __builder2.AddAttribute(67, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                () => EntityItem.CommissionPercentage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "Id", "CommissionPercentage");
                __builder2.AddAttribute(69, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                                                                                                               typeof(LoanRange)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "PropName", "CommissionPercentage");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                        EntityItem.CommissionPercentage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.CommissionPercentage = __value, EntityItem.CommissionPercentage))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal>>>(() => EntityItem.CommissionPercentage));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n    ");
                __builder2.OpenComponent<ComponentLib.Controls.CheckBoxBtn>(75);
                __builder2.AddAttribute(76, "Text", "Group Loan");
                __builder2.AddAttribute(77, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                            EntityItem.GroupLoan

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                              (isgroup) => EntityItem.GroupLoan = isgroup

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n\r\n    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group row mt-5");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-sm-5");
                __builder2.OpenElement(84, "button");
                __builder2.AddAttribute(85, "type", "submit");
                __builder2.AddAttribute(86, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(87, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                                                          Localizer["Create"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 45 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
             if (CreateBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(91);
                __builder2.AddAttribute(92, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n\r\n");
            __builder.OpenElement(94, "a");
            __builder.AddAttribute(95, "class", "btn btn-comp-s btn-sm");
            __builder.AddAttribute(96, "href", "/LoanRanges");
            __builder.AddContent(97, 
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanRanges\LoanRangeCreate.razor"
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
#pragma warning restore 1591
