#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0310ee1b0d5c6568184d936be884f50500b9162"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Shared
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
    public partial class UploadFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatFileUpload>(0);
            __builder.AddAttribute(1, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.IMatFileUploadEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.IMatFileUploadEntry[]>(this, 
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                          Upload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                                          Label

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowMultiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                                                                Multible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                                                                                  CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
 if (ShowUploaded)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "files");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
         foreach(var name in UploadedNames)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "li");
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                  name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 11 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
 if (ImagePreview)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "uploaded-img-preview");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "style", "width:100%; border-radius: 0px 0px 10px 10px;");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 18 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                                                                         Base64Img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 20 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(29);
            __builder.AddAttribute(30, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
                                            Localizer["Uploaded File Validation"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(31, (__value) => {
#nullable restore
#line 22 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\UploadFile.razor"
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
