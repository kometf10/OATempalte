#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71b2ea7e2a84113a76914940cb59a45e9264740"
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
           [Authorize(Policy = "loan-docs-upload")]

#line default
#line hidden
#nullable disable
    public partial class GroupHeadLoanDocs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.OA.WASM.Pages.IBPortal.CustomerPortal.GroupHeadLoanDocs.TypeInference.CreateSequentialTabs_0(__builder, 0, 1, 
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                          TabsData

#line default
#line hidden
#nullable disable
            , 2, "text-center", 3, (context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "detail-key mt-3 mb-3");
                __builder2.AddContent(6, 
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                            Localizer["Upload Member Documents"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " ( ");
                __builder2.AddContent(8, 
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                                    context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, " ) ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<OA.WASM.Pages.IBPortal.CustomerPortal.CustomerLoanDocs>(11);
                __builder2.AddAttribute(12, "LoanProcessId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                         LoanProcessId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "CustomerId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                    context.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "InGroup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ContainedUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                                                                                                    ContainedUpload

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                                      CustomersDocsRef[context.Id] = (OA.WASM.Pages.IBPortal.CustomerPortal.CustomerLoanDocs)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row mt-3 mb-3");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-4");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(22);
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "ClassList", "btn-block btn-sm");
            __builder.AddAttribute(25, "Text", "Confirm");
            __builder.AddAttribute(26, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                                                                      OnConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
         if (UploadBusy)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(30);
            __builder.AddAttribute(31, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(33);
            __builder.AddAttribute(34, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
                                            Localizer["Customer Group Documents Validation"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(35, (__value) => {
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\GroupHeadLoanDocs.razor"
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
namespace __Blazor.OA.WASM.Pages.IBPortal.CustomerPortal.GroupHeadLoanDocs
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSequentialTabs_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::ComponentLib.SequentialTabs<TItem>>(seq);
        __builder.AddAttribute(__seq0, "TabsData", __arg0);
        __builder.AddAttribute(__seq1, "PanelNavClassList", __arg1);
        __builder.AddAttribute(__seq2, "TabTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
