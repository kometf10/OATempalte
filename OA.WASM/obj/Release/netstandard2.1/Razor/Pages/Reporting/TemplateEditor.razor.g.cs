#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d5c9c7718bfff2ee1982ea09617fb953019f50"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Reporting
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
    public partial class TemplateEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tamplate-editor-con");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "report-options-con");
            __builder.AddMarkupContent(4, "<button class=\"btn btn-outline btn-rounded btn-sm comp-icon-btn px-2\" data-toggle=\"modal\" data-target=\"#EditTemplateName\"><i class=\"fas fa-pen\"></i></button>\r\n        ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-outline btn-rounded btn-sm comp-icon-btn px-2");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                                        DeleteTemplate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<i class=\"fas fa-trash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-outline btn-rounded btn-sm comp-icon-btn px-2");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                                        ChangeTemplateState

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
             if (ReportTemplate.Status) 
            { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "i");
            __builder.AddContent(14, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     Localizer["Active"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
            } else { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "i");
            __builder.AddContent(16, 
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     Localizer["Passive"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
            } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "report-headers-con");
            __builder.AddMarkupContent(20, "<button class=\"btn btn-outline btn-rounded btn-sm comp-icon-btn px-2\" data-toggle=\"modal\" data-target=\"#AddHeaderModal\"><i class=\"fas fa-plus\"></i></button>\r\n        ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "section-title");
            __builder.AddContent(23, 
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                      Localizer["Report Headers"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
         foreach (var item in ReportTemplate.ReportHeaders)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row report-header");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-10 report-header-text");
            __builder.AddContent(28, 
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     item.Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-2");
            __builder.AddMarkupContent(32, "<button class=\"close header-edit-icon\" data-toggle=\"modal\" data-target=\"#EditHeaderModal\"><i class=\"fas fa-pen\"></i></button>\r\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "close");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                      () => DeleteHeaedr(item.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, " × ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "report-fields-con");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "class", "section-title");
            __builder.AddContent(42, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                      Localizer["Report Fields"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n        ");
            __Blazor.OA.WASM.Pages.Reporting.TemplateEditor.TypeInference.CreateOrdarableList_0(__builder, 44, 45, 
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                     OrderedFields

#line default
#line hidden
#nullable disable
            , 46, "Key", 47, (context) => (__builder2) => {
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "report-field row");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-md-10");
                __builder2.AddContent(52, 
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                         Localizer[context.Value]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-2");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "class", "close");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                          ()=> RemoveFiled(context.Key)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(59, " × ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 60, (__value) => {
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                             FieldsOrderList = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(61, "\r\n\r\n        ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-sm btn-comp");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                      SaveFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, 
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                    Localizer["Save"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-sm btn-comp-s");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                        ResetFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, 
#nullable restore
#line 62 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                       Localizer["Reset"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(72);
            __builder.AddAttribute(73, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                         DeleteHeaderConfirmEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
               DeleteHeaderConfirm = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(76);
            __builder.AddAttribute(77, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 68 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                           DeleteTemplateConfirmEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(78, (__value) => {
#nullable restore
#line 68 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
               DeleteTemplateConfirm = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(80);
            __builder.AddAttribute(81, "Id", "AddHeaderModal");
            __builder.AddAttribute(82, "Size", "lg");
            __builder.AddAttribute(83, "Title", "Add Report Header");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(85);
                __builder2.AddAttribute(86, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 71 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     ReportHeader

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 71 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                  SaveReportHeader

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(89);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n        ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "row");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col-md-10");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(95);
                    __builder3.AddAttribute(96, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 75 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                     () => ReportHeader.Header

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "Id", "ReportHeader");
                    __builder3.AddAttribute(98, "Label", "Report Header");
                    __builder3.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                         ReportHeader.Header

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ReportHeader.Header = __value, ReportHeader.Header))));
                    __builder3.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ReportHeader.Header));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n        ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "row mt-5");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-md-4");
                    __builder3.OpenElement(107, "button");
                    __builder3.AddAttribute(108, "type", "submit");
                    __builder3.AddAttribute(109, "class", "btn btn-block btn-sm btn-comp");
                    __builder3.AddContent(110, 
#nullable restore
#line 80 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                              Localizer["Save"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Reporting.TemplateEditor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateOrdarableList_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::System.Action<global::ComponentLib.OrdarableList<T>> __arg3)
        {
        __builder.OpenComponent<global::ComponentLib.OrdarableList<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "KeyName", __arg1);
        __builder.AddAttribute(__seq2, "ItemTemplate", __arg2);
        __builder.AddComponentReferenceCapture(__seq3, (__value) => { __arg3((global::ComponentLib.OrdarableList<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591