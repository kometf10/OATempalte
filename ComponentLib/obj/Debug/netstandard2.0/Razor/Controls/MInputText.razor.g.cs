#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c882cadd5f2b3c0e135ccf29e46e3d7ce082f8"
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
    public partial class MInputText : MInputTextBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "md-form");
            __builder.AddMarkupContent(2, "\r\n");
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
     if (MultiLine)
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "textarea");
            __builder.AddAttribute(5, "type", 
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                         Type

#line default
#line hidden
            );
            __builder.AddAttribute(6, "autocomplete", "off");
            __builder.AddAttribute(7, "class", "form-control" + " " + (
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                       CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "id", 
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                                      Id

#line default
#line hidden
            );
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                                                  CurrentValue

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(11, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", 
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                      Type

#line default
#line hidden
            );
            __builder.AddAttribute(16, "autocomplete", "off");
            __builder.AddAttribute(17, "class", "form-control" + " " + (
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                    CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "id", 
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                                   Id

#line default
#line hidden
            );
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                                               CurrentValue

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#line 11 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "for", 
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                 Id

#line default
#line hidden
            );
            __builder.AddAttribute(25, "class", 
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                             Active

#line default
#line hidden
            );
            __builder.AddAttribute(26, "style", "left:unset; right:unset;");
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                                                        Localizer[Label]

#line default
#line hidden
            );
            __builder.AddContent(29, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __Blazor.ComponentLib.Controls.MInputText.TypeInference.CreateCustomValidationMessage_0(__builder, 31, 32, 
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\Controls\MInputText.razor"
                                  For

#line default
#line hidden
            );
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ComponentLib.Controls.MInputText
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
