#pragma checksum "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a9aac249c7da82523613ca2d6a93026aaeb378"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Notifications
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
#line 3 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
           [Authorize(Policy = "push-notification-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PushNotifications")]
    public partial class PushNotifications : PushNotificationsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"page-title\"> Push Notifications </div>\r\n\r\n");
            __builder.OpenComponent<ComponentLib.VerticalTabs>(1);
            __builder.AddAttribute(2, "ListSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                        5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "TabList", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenElement(5, "li");
                __builder2.AddAttribute(6, "class", "tab-list-header p-3");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "span");
                __builder2.AddContent(9, " ");
                __builder2.AddContent(10, 
#nullable restore
#line 10 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                    Localizer["Push Micanism"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(11, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n\r\n        ");
                __builder2.OpenElement(14, "li");
                __builder2.AddAttribute(15, "class", "nav-item");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "a");
                __builder2.AddAttribute(18, "class", "nav-link active");
                __builder2.AddAttribute(19, "data-toggle", "tab");
                __builder2.AddAttribute(20, "id", "broadcast-tab");
                __builder2.AddAttribute(21, "href", "#broadcastContent");
                __builder2.AddAttribute(22, "role", "tab");
                __builder2.AddAttribute(23, "aria-controls", "broadcastContent");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.AddContent(25, 
#nullable restore
#line 15 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                 Localizer["BroadCast Push"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "data-toggle", "tab");
                __builder2.AddAttribute(35, "id", "toUser-tab");
                __builder2.AddAttribute(36, "href", "#toUserContent");
                __builder2.AddAttribute(37, "role", "tab");
                __builder2.AddAttribute(38, "aria-controls", "toUserContent");
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.AddContent(40, 
#nullable restore
#line 20 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                 Localizer["Push To User"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "li");
                __builder2.AddAttribute(45, "class", "nav-item");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "a");
                __builder2.AddAttribute(48, "class", "nav-link");
                __builder2.AddAttribute(49, "data-toggle", "tab");
                __builder2.AddAttribute(50, "id", "toRole-tab");
                __builder2.AddAttribute(51, "href", "#toRoleContent");
                __builder2.AddAttribute(52, "role", "tab");
                __builder2.AddAttribute(53, "aria-controls", "toRoleContent");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.AddContent(55, 
#nullable restore
#line 25 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                 Localizer["Push To Role Group"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n    ");
            }
            ));
            __builder.AddAttribute(59, "TabContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n        \r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(61);
                __builder2.AddAttribute(62, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                         Notification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(65);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n\r\n            ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "form-group row");
                    __builder3.AddMarkupContent(69, "\r\n                ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "col-sm-10");
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(73);
                    __builder3.AddAttribute(74, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                        () => Notification.Title 

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "Id", "Title");
                    __builder3.AddAttribute(76, "Label", "Title");
                    __builder3.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                             Notification.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Notification.Title = __value, Notification.Title))));
                    __builder3.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Notification.Title));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "    \r\n            ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "form-group row");
                    __builder3.AddMarkupContent(85, "\r\n                ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-sm-10");
                    __builder3.AddMarkupContent(88, "\r\n                    ");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(89);
                    __builder3.AddAttribute(90, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 42 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                       () => Notification.Body 

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "Id", "Body");
                    __builder3.AddAttribute(92, "Label", "Body");
                    __builder3.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                             Notification.Body

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Notification.Body = __value, Notification.Body))));
                    __builder3.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Notification.Body));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n\r\n            ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "tab-pane active");
                    __builder3.AddAttribute(101, "id", "broadcastContent");
                    __builder3.AddAttribute(102, "role", "tabpanel");
                    __builder3.AddAttribute(103, "aria-labelledby", "broadcast-tab");
                    __builder3.AddMarkupContent(104, "\r\n\r\n                ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "form-group row mt-5");
                    __builder3.AddMarkupContent(107, "\r\n                    ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col-sm-5");
                    __builder3.AddMarkupContent(110, "\r\n                        ");
                    __builder3.OpenElement(111, "button");
                    __builder3.AddAttribute(112, "class", "btn btn-comp btn-block btn-sm");
                    __builder3.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                BroadCast

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(114, " ");
                    __builder3.AddContent(115, 
#nullable restore
#line 50 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                              Localizer["BroadCast"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(116, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\r\n                    ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-sm-1 pt-1 text-center");
                    __builder3.AddMarkupContent(121, "\r\n");
#nullable restore
#line 53 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                         if (PushBusy)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<ComponentLib.MiniLoading>(122);
                    __builder3.AddAttribute(123, "size", "25px");
                    __builder3.CloseComponent();
#nullable restore
#line 54 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(124, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\r\n\r\n            ");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "tab-pane");
                    __builder3.AddAttribute(130, "id", "toUserContent");
                    __builder3.AddAttribute(131, "role", "tabpanel");
                    __builder3.AddAttribute(132, "aria-labelledby", "toUser-tab");
                    __builder3.AddMarkupContent(133, "\r\n\r\n                ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "class", "form-group row");
                    __builder3.AddMarkupContent(136, "\r\n                    ");
                    __builder3.OpenElement(137, "div");
                    __builder3.AddAttribute(138, "class", "col-sm-10");
                    __builder3.AddMarkupContent(139, "\r\n                        ");
                    __Blazor.OA.WASM.Pages.Notifications.PushNotifications.TypeInference.CreateMInputSelect_0(__builder3, 140, 141, 
#nullable restore
#line 64 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                             Users

#line default
#line hidden
#nullable disable
                    , 142, 
#nullable restore
#line 64 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                             ()=> Notification.UserId

#line default
#line hidden
#nullable disable
                    , 143, "UserId", 144, "User", 145, 
#nullable restore
#line 64 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                 Notification.UserId

#line default
#line hidden
#nullable disable
                    , 146, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Notification.UserId = __value, Notification.UserId)), 147, () => Notification.UserId);
                    __builder3.AddMarkupContent(148, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(149, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(150, "\r\n\r\n                ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "form-group row mt-5");
                    __builder3.AddMarkupContent(153, "\r\n                    ");
                    __builder3.OpenElement(154, "div");
                    __builder3.AddAttribute(155, "class", "col-sm-5");
                    __builder3.AddMarkupContent(156, "\r\n                        ");
                    __builder3.OpenElement(157, "button");
                    __builder3.AddAttribute(158, "class", "btn btn-comp btn-block btn-sm");
                    __builder3.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                PushToUser

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(160, " ");
                    __builder3.AddContent(161, 
#nullable restore
#line 70 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                              Localizer["Push To User"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(162, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(164, "\r\n                    ");
                    __builder3.OpenElement(165, "div");
                    __builder3.AddAttribute(166, "class", "col-sm-1 pt-1 text-center");
                    __builder3.AddMarkupContent(167, "\r\n");
#nullable restore
#line 73 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                         if (PushBusy)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<ComponentLib.MiniLoading>(168);
                    __builder3.AddAttribute(169, "size", "25px");
                    __builder3.CloseComponent();
#nullable restore
#line 74 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(170, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(172, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\r\n\r\n            ");
                    __builder3.OpenElement(174, "div");
                    __builder3.AddAttribute(175, "class", "tab-pane");
                    __builder3.AddAttribute(176, "id", "toRoleContent");
                    __builder3.AddAttribute(177, "role", "tabpanel");
                    __builder3.AddAttribute(178, "aria-labelledby", "toRole-tab");
                    __builder3.AddMarkupContent(179, "\r\n\r\n                ");
                    __builder3.OpenElement(180, "div");
                    __builder3.AddAttribute(181, "class", "form-group row");
                    __builder3.AddMarkupContent(182, "\r\n                    ");
                    __builder3.OpenElement(183, "div");
                    __builder3.AddAttribute(184, "class", "col-sm-10");
                    __builder3.AddMarkupContent(185, "\r\n                        ");
                    __Blazor.OA.WASM.Pages.Notifications.PushNotifications.TypeInference.CreateMInputSelect_1(__builder3, 186, 187, 
#nullable restore
#line 84 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                             Roles

#line default
#line hidden
#nullable disable
                    , 188, 
#nullable restore
#line 84 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                             ()=> Notification.UserId

#line default
#line hidden
#nullable disable
                    , 189, "RoleId", 190, "Role", 191, 
#nullable restore
#line 84 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                 Notification.UserId

#line default
#line hidden
#nullable disable
                    , 192, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Notification.UserId = __value, Notification.UserId)), 193, () => Notification.UserId);
                    __builder3.AddMarkupContent(194, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(195, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(196, "\r\n\r\n                ");
                    __builder3.OpenElement(197, "div");
                    __builder3.AddAttribute(198, "class", "form-group row mt-5");
                    __builder3.AddMarkupContent(199, "\r\n                    ");
                    __builder3.OpenElement(200, "div");
                    __builder3.AddAttribute(201, "class", "col-sm-5");
                    __builder3.AddMarkupContent(202, "\r\n                        ");
                    __builder3.OpenElement(203, "button");
                    __builder3.AddAttribute(204, "class", "btn btn-comp btn-block btn-sm");
                    __builder3.AddAttribute(205, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                PushToRole

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(206, " ");
                    __builder3.AddContent(207, 
#nullable restore
#line 90 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                                                              Localizer["Push To Role"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(208, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(209, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(210, "\r\n                    ");
                    __builder3.OpenElement(211, "div");
                    __builder3.AddAttribute(212, "class", "col-sm-1 pt-1 text-center");
                    __builder3.AddMarkupContent(213, "\r\n");
#nullable restore
#line 93 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                         if (PushBusy)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<ComponentLib.MiniLoading>(214);
                    __builder3.AddAttribute(215, "size", "25px");
                    __builder3.CloseComponent();
#nullable restore
#line 94 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(216, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(217, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(218, "\r\n\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(219, "\r\n\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(220, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(221, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(222);
            __builder.AddAttribute(223, "Title", "Validation");
            __builder.AddComponentReferenceCapture(224, (__value) => {
#nullable restore
#line 105 "D:\.net core Template\Try 14 IBP\OA_sln\OA.WASM\Pages\Notifications\PushNotifications.razor"
                        Validation = (ComponentLib.ServerValidation)__value;

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
namespace __Blazor.OA.WASM.Pages.Notifications.PushNotifications
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMInputSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg6)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Label", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMInputSelect_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg6)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Label", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
