#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef035277f57da5c7e5eb17ea373a98ac723cc0b"
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class VerticalTabs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "tabs-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-" + (
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                            ListSize

#line default
#line hidden
            ) + " col-lg-" + (
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                                              ListSize - 2

#line default
#line hidden
            ));
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "nav nav-tabs flex-column mb-3");
            __builder.AddAttribute(8, "role", "tablist");
            __builder.AddContent(9, 
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                 TabList

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-" + (
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                            ConSize

#line default
#line hidden
            ) + " col-lg-" + (
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                                             ConSize + 2

#line default
#line hidden
            ));
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "tab-content");
            __builder.AddContent(15, 
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\VerticalTabs.razor"
                 TabContent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591