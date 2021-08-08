#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\RowOptions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5c42ba6d6672500a80b54407c144dd95e87eaa"
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
    public partial class RowOptions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "options-con");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "option-toggle");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(6);
            __builder.AddAttribute(7, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(8, "IconClassList", "fas fa-cogs");
            __builder.AddAttribute(9, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\RowOptions.razor"
                                                                                                                ToggleOptions

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "options" + " " + (
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\RowOptions.razor"
                         open

#line default
#line hidden
            ));
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "option");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddContent(18, 
#line 9 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\RowOptions.razor"
             Option

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\RowOptions.razor"
      


    //[Parameter]
    //public IEnumerable<RenderFragment> Options {get; set;}

    [Parameter]
    public RenderFragment Option { get; set; }


    public string open { get; set; } = "";

    public void ToggleOptions()
    {
        if (string.IsNullOrEmpty(open))
            open = "options-open";
        else
            open = "";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591