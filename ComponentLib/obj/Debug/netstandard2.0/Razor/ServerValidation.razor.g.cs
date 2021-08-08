#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59e4d2a65ada177bf143746203db328989c3eed"
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
    public partial class ServerValidation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
 if (Show)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade d-block show");
            __builder.AddAttribute(3, "id", "ValidationModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "ValidationModalLbl");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-header");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "modal-title");
            __builder.AddAttribute(21, "id", "ValidationModalLbl");
            __builder.AddContent(22, " ");
            __builder.AddContent(23, 
#line 9 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                                                      Localizer[Title]

#line default
#line hidden
            );
            __builder.AddContent(24, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body pl-5 pr-5");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "ul");
            __builder.AddMarkupContent(31, "\r\n");
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                         foreach (var error in Errors)
                        {

#line default
#line hidden
            __builder.AddContent(32, "                            ");
            __builder.OpenElement(33, "li");
            __builder.AddMarkupContent(34, " \r\n                                ");
            __builder.AddContent(35, 
#line 16 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                 Localizer[error.Field]

#line default
#line hidden
            );
            __builder.AddMarkupContent(36, " : \r\n                                ");
            __builder.OpenElement(37, "ul");
            __builder.AddMarkupContent(38, "\r\n");
#line 18 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                     foreach(var fieldError in error.Errors)
                                    {

#line default
#line hidden
            __builder.AddContent(39, "                                        ");
            __builder.OpenElement(40, "li");
            __builder.AddMarkupContent(41, "\r\n                                            ");
            __builder.AddContent(42, 
#line 21 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                             Localizer[fieldError]

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#line 23 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                    }

#line default
#line hidden
            __builder.AddContent(45, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#line 26 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                        }

#line default
#line hidden
            __builder.AddContent(48, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-footer");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 30 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
                                                                                  () => CloseValidation()

#line default
#line hidden
            ));
            __builder.AddContent(58, " Ok ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#line 35 "D:\.net core Template\Try 14 IBP\OA_sln\ComponentLib\ServerValidation.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
