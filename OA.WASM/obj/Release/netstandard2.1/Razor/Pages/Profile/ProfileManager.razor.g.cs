#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726994ec267b4317a881de0b60976c5b44712f01"
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
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
using OA.WASM.Pages.Administration.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
using OA.Domin.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
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
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "profile-img-name");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "profile-img");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                       ImgData

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenComponent<OA.WASM.Shared.UploadFile>(9);
            __builder.AddAttribute(10, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                  FileSettings.MimeTypes["Image"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ImagePreview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ShowUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                           false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "MaxSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                 1024 * 1024 * 1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                       OnValidUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnStartPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                          StartPreUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "OnEndPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                        EndPreUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "CssClass", "profile-img-btn");
            __builder.AddComponentReferenceCapture(18, (__value) => {
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                              UploadedPic = (OA.WASM.Shared.UploadFile)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "profile-name");
            __builder.AddContent(22, 
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
             UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "profie-form");
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
         if (!string.IsNullOrEmpty(UserId))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<OA.WASM.Pages.Administration.Users.UserEdit>(26);
            __builder.AddAttribute(27, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                           UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ProfileUse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "M-center");
            __builder.OpenComponent<ComponentLib.MiniLoading>(31);
            __builder.AddAttribute(32, "size", "70px");
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Confirm>(33);
            __builder.AddAttribute(34, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                             Localizer["Confirm Set Profile Pic"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                                                                                                        SubmitProfilePic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
                       Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
         if(UploadBusy)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(37);
            __builder.AddAttribute(38, "size", "35px");
            __builder.CloseComponent();
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Profile\ProfileManager.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
