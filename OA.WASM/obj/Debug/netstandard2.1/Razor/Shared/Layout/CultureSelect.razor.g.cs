#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\Layout\CultureSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da7f27883a5360b9425cce12d51324f95f5026b"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Shared.Layout
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
    public partial class CultureSelect : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .nav-drop-con{
        list-style: none;
        margin-left: 30px;
        margin-right: 30px;
    }
    .nav-drop-toggle{
        text-decoration: none;
        cursor: pointer;
    }
    .nav-drop-item{
        color: gray;
        padding-left: 30px;
        padding-right: 30px;
        cursor: pointer;
    }
    .nav-drop-item:hover{
        background-color: #DDD;
    }

</style>

");
            __builder.OpenElement(1, "li");
            __builder.AddAttribute(2, "class", "nav-drop-con");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "class", "nav-drop-toggle dropdown-toggle");
            __builder.AddAttribute(6, "data-toggle", "dropdown");
            __builder.AddAttribute(7, "role", "button");
            __builder.AddAttribute(8, "aria-haspopup", "true");
            __builder.AddAttribute(9, "aria-expanded", "true");
            __builder.AddMarkupContent(10, " \r\n        ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "nav-label");
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 28 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\Layout\CultureSelect.razor"
                                  CurrentLang

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<span class=\"caret\"> </span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "dropdown-menu nav-drop-items");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-drop-item");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\Layout\CultureSelect.razor"
                                            () => SelectLanguage("en-US")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "  EN  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-drop-item");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Shared\Layout\CultureSelect.razor"
                                            () => SelectLanguage("ar-SY")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, " AR  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<CommonResources> Localizer { get; set; }
    }
}
#pragma warning restore 1591
