#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0e8bf72d8a8205e3ceab61a457652e3d514c2c"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.LoanRequests
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
    public partial class GuaranteeItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
 if (Guarantee != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dynamic-row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6 text-center");
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                 if (GuaranteeTypeItems.ContainsKey(Guarantee.GuaranteeTypeId.ToString()))
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                     GuaranteeTypeItems[Guarantee.GuaranteeTypeId.ToString()]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                                                             
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-6 text-center");
            __builder.AddContent(10, 
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                                Guarantee.GuaranteeEstematedValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row mt-2");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-10 text-center");
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                 if (Guarantee.GuaranteeTypeId == 1)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "pt-3");
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                         if (GuarantorItems.ContainsKey(Guarantee.GurantorId.ToString()))
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, 
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                             GuarantorItems[Guarantee.GurantorId.ToString()]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                                                            
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                }
                else if (Guarantee.GuaranteeTypeId == 2)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.CollapseContainer>(19);
            __builder.AddAttribute(20, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                             $"VehicleInfoView_{Guarantee.Id}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Title", "Vehicle Info");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row mt-3 mb-3");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-md-4 text-center");
                __builder2.AddContent(27, 
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.PlateNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-4 text-center");
                __builder2.AddContent(31, 
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.Catigory

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-4 text-center");
                __builder2.AddContent(35, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.ModelYear

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group row mt-3 mb-3");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-4 text-center");
                __builder2.AddContent(41, 
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.Manufacture

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-4 text-center");
                __builder2.AddContent(45, 
#nullable restore
#line 44 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.Model

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-4 text-center");
                __builder2.AddContent(49, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.FirstRegisterYear

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group row mt-3 mb-3");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-md-4 text-center");
                __builder2.AddContent(55, 
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.OwnerName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-4 text-center");
                __builder2.AddContent(59, 
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.InsuranceType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-md-4 text-center");
                __builder2.AddContent(63, 
#nullable restore
#line 58 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                 Guarantee.Vehicle.InsuranceDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 62 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-2 mt-3 text-center");
#nullable restore
#line 65 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                 if (ActiveControl)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(67);
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(70, "IconClassList", "fa fa-trash");
            __builder.AddAttribute(71, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                                                                                                                                            () => Remove()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 68 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        <div class=\"row\"></div>");
            __builder.CloseElement();
#nullable restore
#line 75 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\GuaranteeItem.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
