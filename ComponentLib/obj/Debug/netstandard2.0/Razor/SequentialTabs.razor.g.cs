#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212b30c7998f9f4ef865dadc965865da2383d5e3"
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
    public partial class SequentialTabs<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "seq-tabs");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "panelNav" + " " + (
#line 49 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                         PanelNavClassList

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "data-panelwrapper", "panelWrapper_" + (
#line 49 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                             PanelNavId

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "id", 
#line 49 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                              PanelNavId

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 50 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
           var i = 0; 

#line default
#line hidden
#line 51 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
         foreach (var tabData in TabsData)
        {
            var tab = tabData.Key;


#line default
#line hidden
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "seq-tab");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                           $"#panel_{tab}"

#line default
#line hidden
            );
            __builder.AddAttribute(14, "class", 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                      (i == 0)? "active": ""

#line default
#line hidden
            );
            __builder.AddEventPreventDefaultAttribute(15, "onclick", 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                        true

#line default
#line hidden
            );
            __builder.AddAttribute(16, "id", 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                                    $"tab_{tab}"

#line default
#line hidden
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                                                               () => OnTabClick($"tab_{tab}")

#line default
#line hidden
            ));
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#line 56 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                                                                                                  tab

#line default
#line hidden
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 58 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"

            i++;
        }

#line default
#line hidden
            __builder.AddContent(23, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "panelWrapper" + " " + (
#line 62 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                              PanelWrapperClassList

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "id", "panelWrapper_" + (
#line 62 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                       PanelNavId

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "data-enter", 
#line 62 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                DataEnter

#line default
#line hidden
            );
            __builder.AddAttribute(29, "data-exit", 
#line 62 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                                       DataExit

#line default
#line hidden
            );
            __builder.AddAttribute(30, "data-sequential", 
#line 62 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                                                                                   DataSequential

#line default
#line hidden
            );
            __builder.AddMarkupContent(31, "\r\n\r\n");
#line 64 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
           i = 0; 

#line default
#line hidden
#line 65 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
         foreach (var tabData in TabsData)
        {
            var tab = tabData.Key;
            var data = tabData.Value;


#line default
#line hidden
            __builder.AddContent(32, "            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", (
#line 70 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                         PanelClassList

#line default
#line hidden
            ) + " panel" + " " + (
#line 70 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                (i == 0)? "current": ""

#line default
#line hidden
            ) + " ");
            __builder.AddAttribute(35, "id", 
#line 70 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                                                                                 $"panel_{tab}"

#line default
#line hidden
            );
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddContent(37, 
#line 71 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"
                 TabTemplate(data)

#line default
#line hidden
            );
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#line 73 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\SequentialTabs.razor"


            i++;
        }

#line default
#line hidden
            __builder.AddContent(40, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
