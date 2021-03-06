#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2267de66c2dd557430906918343551fee56f64c"
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
    public partial class GridRowOptions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "options-con");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "option-toggle");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(4);
            __builder.AddAttribute(5, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(6, "IconClassList", "fas fa-cogs");
            __builder.AddAttribute(7, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
                                                                                                                ToggleOptions

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "options" + " " + (
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
                         open

#line default
#line hidden
            ));
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
         if (EditEvent.HasDelegate)
        {

#line default
#line hidden
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "option");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(13);
            __builder.AddAttribute(14, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(15, "IconClassList", "fas fa-edit");
            __builder.AddAttribute(16, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
                                        EditEvent

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
        }

#line default
#line hidden
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
         if (DeleteEvent.HasDelegate)
        {

#line default
#line hidden
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "option");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(19);
            __builder.AddAttribute(20, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(21, "IconClassList", "fas fa-trash-alt");
            __builder.AddAttribute(22, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
                                        DeleteEvent

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#line 20 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
        }

#line default
#line hidden
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
         if (DetailsEvent.HasDelegate)
        {

#line default
#line hidden
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "option");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(25);
            __builder.AddAttribute(26, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(27, "IconClassList", "fas fa-info-circle");
            __builder.AddAttribute(28, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
                                        DetailsEvent

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
        }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\GridRowOptions.razor"
      

    [Parameter]
    public EventCallback EditEvent { get; set; }

    [Parameter]
    public EventCallback DeleteEvent { get; set; }

    [Parameter]
    public EventCallback DetailsEvent { get; set; }


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
