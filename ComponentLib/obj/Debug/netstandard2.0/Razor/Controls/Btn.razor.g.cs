#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\Btn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b976ac40edd241724881cad31a651621339b3c"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLib.Controls
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
    public partial class Btn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn" + " btn-comp" + " " + (
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\Btn.razor"
                             ClassList

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\Btn.razor"
                                                  BtnClick

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\Btn.razor"
                                                                         Attrs

#line default
#line hidden
            ));
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\Btn.razor"
                                                                                  Text

#line default
#line hidden
            );
            __builder.AddContent(6, " ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591