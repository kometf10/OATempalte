#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726994ec267b4317a881de0b60976c5b44712f01"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Profile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
using OA.WASM.Pages.Administration.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
using OA.Domin.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class ProfileManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "profile-container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "profile-img-name");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "profile-img");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                       ImgData

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n            ");
            __builder.OpenComponent<OA.WASM.Shared.UploadFile>(12);
            __builder.AddAttribute(13, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                  FileSettings.MimeTypes["Image"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ImagePreview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ShowUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                           false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "MaxSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 14 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                 1024 * 1024 * 1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                       OnValidUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "OnStartPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                          StartPreUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "OnEndPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                        EndPreUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "CssClass", "profile-img-btn");
            __builder.AddComponentReferenceCapture(21, (__value) => {
#nullable restore
#line 12 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                              UploadedPic = (OA.WASM.Shared.UploadFile)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "profile-name");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddContent(27, 
#nullable restore
#line 21 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
             UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "profie-form");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 25 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
         if (!string.IsNullOrEmpty(UserId))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.OpenComponent<OA.WASM.Pages.Administration.Users.UserEdit>(35);
            __builder.AddAttribute(36, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                           UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ProfileUse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 28 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "M-center");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenComponent<ComponentLib.MiniLoading>(43);
            __builder.AddAttribute(44, "size", "70px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 34 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.Confirm>(48);
            __builder.AddAttribute(49, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                             Localizer["Confirm Set Profile Pic"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                                                                        SubmitProfilePic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(51, (__value) => {
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                       Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 38 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
         if(UploadBusy)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.OpenComponent<ComponentLib.MiniLoading>(54);
            __builder.AddAttribute(55, "size", "35px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 41 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
