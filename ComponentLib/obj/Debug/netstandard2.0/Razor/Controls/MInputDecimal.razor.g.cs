#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23dc146014485c8322a9dd4e8a629f5443f262fd"
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
    public partial class MInputDecimal : MInputDecimalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "md-form");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "autocomplete", "off");
            __builder.AddAttribute(6, "class", "form-control" + " " + (
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                                                                 CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "id", 
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                                                                                Id

#line default
#line hidden
            );
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                                                                                            CurrentValue

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "label");
            __builder.AddAttribute(12, "for", 
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                 Id

#line default
#line hidden
            );
            __builder.AddAttribute(13, "class", "active");
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                                      Localizer[Label]

#line default
#line hidden
            );
            __builder.AddContent(16, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __Blazor.ComponentLib.Controls.MInputDecimal.TypeInference.CreateCustomValidationMessage_0(__builder, 18, 19, 
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputDecimal.razor"
                                  For

#line default
#line hidden
            );
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ComponentLib.Controls.MInputDecimal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomValidationMessage_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0)
        {
        __builder.OpenComponent<global::ComponentLib.CustomValidationMessage<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
