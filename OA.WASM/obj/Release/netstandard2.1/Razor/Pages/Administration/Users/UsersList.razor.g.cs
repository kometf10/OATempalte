#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "962d9ee46ca835c4d04f02c187d7ab287b56af06"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Administration.Users
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
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
using OA.Domin.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
           [Authorize(Policy = "administration-users")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class UsersList : UsersListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
 if (Users == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "position:relative; height:40px");
            __builder.AddAttribute(3, "class", "mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-title filter-title");
            __builder.AddContent(6, 
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                               Localizer["Users"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter-link");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(10);
            __builder.AddAttribute(11, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(12, "IconClassList", "fas fa-plus");
            __builder.AddAttribute(13, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("users/create") 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "mt-5 mb-5");
            __builder.OpenComponent<ComponentLib.CollapseContainer>(17);
            __builder.AddAttribute(18, "Id", "Filters");
            __builder.AddAttribute(19, "Title", "Filters");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
                __builder2.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                             UserFilter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "row");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "col-md-6");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(28);
                    __builder3.AddAttribute(29, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                             () => UserFilter.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Id", "UserNameFilter");
                    __builder3.AddAttribute(31, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                                                                         typeof(CustomUser)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "PropName", "UserName");
                    __builder3.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                 UserFilter.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserFilter.UserName = __value, UserFilter.UserName))));
                    __builder3.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserFilter.UserName));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n                    ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "col-md-6");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(39);
                    __builder3.AddAttribute(40, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                          () => UserFilter.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Id", "EmailFilter");
                    __builder3.AddAttribute(42, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                                                                   typeof(CustomUser)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "PropName", "Email");
                    __builder3.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                 UserFilter.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserFilter.Email = __value, UserFilter.Email))));
                    __builder3.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserFilter.Email));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n                ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "row mb-4");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-6");
                    __Blazor.OA.WASM.Pages.Administration.Users.UsersList.TypeInference.CreateMInputSelect_0(__builder3, 52, 53, 
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                               () => UserFilter.BranchId

#line default
#line hidden
#nullable disable
                    , 54, 
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                                                  BranchItems

#line default
#line hidden
#nullable disable
                    , 55, "BranchFilter", 56, 
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                                                                                             typeof(CustomUser)

#line default
#line hidden
#nullable disable
                    , 57, "BranchId", 58, 
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                   UserFilter.BranchId

#line default
#line hidden
#nullable disable
                    , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserFilter.BranchId = __value, UserFilter.BranchId)), 60, () => UserFilter.BranchId);
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                    <div class=\"col-md-6\"></div>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "row");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "col-md-6");
                    __builder3.OpenComponent<ComponentLib.Controls.Btn>(67);
                    __builder3.AddAttribute(68, "type", "button");
                    __builder3.AddAttribute(69, "ClassList", "btn-sm");
                    __builder3.AddAttribute(70, "Text", "Search");
                    __builder3.AddAttribute(71, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 40 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                           FilterUsers

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __Blazor.OA.WASM.Pages.Administration.Users.UsersList.TypeInference.CreateGrid_1(__builder, 72, 73, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                 Users

#line default
#line hidden
#nullable disable
            , 74, (__builder2) => {
                __builder2.OpenElement(75, "th");
                __builder2.AddContent(76, 
#nullable restore
#line 49 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                  Localizer["User Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.OpenElement(78, "th");
                __builder2.AddContent(79, 
#nullable restore
#line 50 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                  Localizer["Email"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "th");
                __builder2.AddContent(82, 
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                  Localizer["Branch"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenElement(84, "th");
                __builder2.AddContent(85, 
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                  Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            , 86, (context) => (__builder2) => {
                __builder2.OpenElement(87, "td");
                __builder2.OpenElement(88, "span");
                __builder2.AddContent(89, 
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                         Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(90, "  ");
                __builder2.AddContent(91, 
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                     context.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "td");
                __builder2.OpenElement(94, "span");
                __builder2.AddContent(95, 
#nullable restore
#line 56 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                         Localizer["Email"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(96, "  ");
                __builder2.AddContent(97, 
#nullable restore
#line 56 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                      context.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "td");
                __builder2.OpenElement(100, "span");
                __builder2.AddContent(101, 
#nullable restore
#line 58 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                        Localizer["Branch"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 59 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                 if (BranchItems.ContainsKey(context.BranchId.ToString()))
                {
                    

#line default
#line hidden
#nullable disable
                __builder2.AddContent(102, 
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                     BranchItems[context.BranchId.ToString()]

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                              
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.OpenElement(104, "td");
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(105);
                __builder2.AddAttribute(106, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 65 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                             () => NavigationManager.NavigateTo("/users/edit/" + context.Id ) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(107, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 66 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                               () => DeleteUser(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(108, "DetailsEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                () => NavigationManager.NavigateTo("#")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.OpenComponent<ComponentLib.Pagination>(109);
            __builder.AddAttribute(110, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 72 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                            PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 72 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                          SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(112, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 72 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 73 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Confirm>(113);
            __builder.AddAttribute(114, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 77 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(115, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(116, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(117, (__value) => {
#nullable restore
#line 77 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Administration\Users\UsersList.razor"
                                                       Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Administration.Users.UsersList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMInputSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg7)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateGrid_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::ComponentLib.Grid<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "GridHeader", __arg1);
        __builder.AddAttribute(__seq2, "GridRow", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
