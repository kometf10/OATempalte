#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\CustomValidationMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8184be3441cde6ceb171968223f393dad4715c0a"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLib
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class CustomValidationMessage<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\CustomValidationMessage.razor"
 if (ValidationMessages.Any())
{
    foreach(var msg in ValidationMessages)
    {

#line default
#line hidden
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", (
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\CustomValidationMessage.razor"
                     ClassList

#line default
#line hidden
            ) + " text-danger");
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\CustomValidationMessage.razor"
                                              Localizer[msg]

#line default
#line hidden
            );
            __builder.AddContent(5, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\CustomValidationMessage.razor"
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
