#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5efc4187c2d3c7f855430876fde4c2eb91cd8b6"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Logging.AdminLog
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
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
           [Authorize(Policy = "error-log-access")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ErrorsLog")]
    public partial class ExceptionLogList : ExceptionLogListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
 if (ListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "position:relative");
            __builder.AddAttribute(3, "class", "mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-title filter-title");
            __builder.AddContent(6, 
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                               Localizer["Errors Log"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.GridFilter<OA.Domin.Logging.ExceptionLog>>(8);
            __builder.AddAttribute(9, "SearchSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>(this, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                                    SearchEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                                                       GridFilterRef = (ComponentLib.GridFilter<OA.Domin.Logging.ExceptionLog>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "export-links");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(14);
            __builder.AddAttribute(15, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(16, "IconClassList", "far fa-file-excel i-lg");
            __builder.AddAttribute(17, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                                                                                                 () => Export("Exel", nameof(OA.Domin.Logging.ExceptionLog))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(19);
            __builder.AddAttribute(20, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(21, "IconClassList", "far fa-file-pdf i-lg");
            __builder.AddAttribute(22, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                                                                                               () => Export("Pdf", nameof(OA.Domin.Logging.ExceptionLog))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 20 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
             if (ExportBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(23);
            __builder.AddAttribute(24, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __Blazor.OA.WASM.Pages.Logging.AdminLog.ExceptionLogList.TypeInference.CreateGrid_0(__builder, 25, 26, 
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                 ListData

#line default
#line hidden
#nullable disable
            , 27, (__builder2) => {
                __builder2.OpenElement(28, "th");
                __builder2.AddContent(29, 
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                  Localizer["Message"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "th");
                __builder2.AddContent(32, 
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                  Localizer["Path"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "th");
                __builder2.AddContent(35, 
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                  Localizer["StackTrace"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "th");
                __builder2.AddContent(38, 
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                  Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "th");
                __builder2.AddContent(41, 
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                  Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            , 42, (context) => (__builder2) => {
                __builder2.OpenElement(43, "td");
                __builder2.OpenElement(44, "span");
                __builder2.AddContent(45, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                         Localizer["Message"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(46, "  ");
                __builder2.AddContent(47, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                        context.Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "td");
                __builder2.OpenElement(50, "span");
                __builder2.AddContent(51, 
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                         Localizer["Path"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(52, "  ");
                __builder2.AddContent(53, 
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                     context.Path

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "td");
                __builder2.OpenElement(56, "span");
                __builder2.AddContent(57, 
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                         Localizer["StackTrace"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(58, "  ");
                __builder2.AddContent(59, 
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                            (context.StackTrace != null)? $"{context.StackTrace.Substring(0, 100)} ... ": "" 

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenElement(61, "td");
                __builder2.OpenElement(62, "span");
                __builder2.AddContent(63, 
#nullable restore
#line 39 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                         Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(64, "  ");
                __builder2.AddContent(65, 
#nullable restore
#line 39 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                     context.CreatedAt

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "td");
                __builder2.OpenComponent<ComponentLib.Controls.IconBtn>(68);
                __builder2.AddAttribute(69, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
                __builder2.AddAttribute(70, "IconClassList", "fas fa-info-circle");
                __builder2.AddAttribute(71, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                          () => ShowDetails(context.StackTrace)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(72, "data-toggle", "modal");
                __builder2.AddAttribute(73, "data-target", "#DetailsModal");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.OpenComponent<ComponentLib.Pagination>(74);
            __builder.AddAttribute(75, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                            PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                          SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(77, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.ModalContainer>(78);
            __builder.AddAttribute(79, "Id", "DetailsModal");
            __builder.AddAttribute(80, "Size", "lg");
            __builder.AddAttribute(81, "Title", "Error Details");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", true);
                __builder2.AddContent(85, 
#nullable restore
#line 53 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Logging\AdminLog\ExceptionLogList.razor"
         CurrntDetails

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Logging.AdminLog.ExceptionLogList
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
