#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa0e1e575c4761ad887a470611497daf1547e4f"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.CustomerPortal
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
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
           [Authorize(Policy = "bank-customer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AuthorizeGroupHead")]
    public partial class AuthorizeGroupHead : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
     Localizer["Authorize Your Group Head"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, " \r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mt-3 mb-3");
            __builder.OpenElement(6, "small");
            __builder.AddAttribute(7, "class", "alert alert-info");
            __builder.AddContent(8, 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
         Localizer["Customer Autorized by you as a group head can add group loan request with you in it as a member"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row mt-5 mb-5");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-4 detail-key");
            __builder.AddContent(14, 
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
         Localizer["Current Authorized Group Head : "]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-6");
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
         if (CurrentGroupHead != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
             if (!string.IsNullOrEmpty(CurrentGroupHead.Name))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "ml-3 mr-3");
            __builder.AddContent(20, 
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                          CurrentGroupHead.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "span");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(23);
            __builder.AddAttribute(24, "ClassList", "btn-sm");
            __builder.AddAttribute(25, "Text", "UnAuthorize");
            __builder.AddAttribute(26, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                                                              UnAuthorizeGroupHeadCustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, 
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                 Localizer["No Current Authorized Group Head"]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                                              
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(28);
            __builder.AddAttribute(29, "size", "20px");
            __builder.CloseComponent();
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.AddMarkupContent(31, "<div class=\"mb-3 mt-5 detail-key\"> Change Authorized Group Head Customer By National Number</div>\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "mt-3 mb-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(34);
            __builder.AddAttribute(35, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 44 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                     NationalNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group row");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(41);
                __builder2.AddAttribute(42, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                                                () => NationalNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Id", "NatNum");
                __builder2.AddAttribute(44, "Label", "National Number");
                __builder2.AddAttribute(45, "Active", "active");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                         NationalNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NationalNumber = __value, NationalNumber))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NationalNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row mt-5");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.Btn>(54);
                __builder2.AddAttribute(55, "ClassList", "btn-sm btn-block");
                __builder2.AddAttribute(56, "Text", "Authorize");
                __builder2.AddAttribute(57, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 53 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                                                                  AuthorizeGroupHeadCustomer

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 56 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                 if (SubmitBusy)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(61);
                __builder2.AddAttribute(62, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 57 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(64);
            __builder.AddComponentReferenceCapture(65, (__value) => {
#nullable restore
#line 64 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\AuthorizeGroupHead.razor"
                        Validation = (ComponentLib.ServerValidation)__value;

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
#pragma warning restore 1591
