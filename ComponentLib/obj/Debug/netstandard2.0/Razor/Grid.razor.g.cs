#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fde9bf5676fee102ed8c8d8b27a7a132d5ed8a"
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
    public partial class Grid<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table grid-comp");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor"
              GridHeader

#line default
#line hidden
            );
            __builder.AddContent(8, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor"
           
            int i = 0;
            foreach (var item in Items)
            {

#line default
#line hidden
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "class", 
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor"
                             (i%2 == 0)? "even" : "odd"

#line default
#line hidden
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor"
                                                             GridRow(item)

#line default
#line hidden
            );
            __builder.AddContent(18, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Grid.razor"

                i++;
            }
        

#line default
#line hidden
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591