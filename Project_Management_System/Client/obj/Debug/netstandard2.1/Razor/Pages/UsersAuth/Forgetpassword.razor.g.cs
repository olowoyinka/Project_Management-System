#pragma checksum "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c65d15ed389784b3bcc9fea593998dd2d943951"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_Management_System.Client.Pages.UsersAuth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Pages.UsersAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Respository.RespositoryInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Shared.Models.ChatModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.UserRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.ViewModelResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.ViewModelRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.UserResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoNavBar))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/forgetpassword")]
    public partial class Forgetpassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "hold-transition login-page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "login-box");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"login-logo\">\r\n            <a href=\"/login\"><b>Proj</b>MAN</a>\r\n        </div>\r\n        \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body login-card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<p class=\"login-box-msg\">You forgot your password? Here you can easily retrieve a new password.</p>\r\n");
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                 if (loginFailure)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "text-danger");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "h6");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                             ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 20 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "text-danger");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "h6");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.AddContent(30, 
#nullable restore
#line 25 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                             ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 28 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(35);
            __builder.AddAttribute(36, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                                 userRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                                                             ForgetPassword

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(40);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "text-danger");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __Blazor.Project_Management_System.Client.Pages.UsersAuth.Forgetpassword.TypeInference.CreateValidationMessage_0(__builder2, 45, 46, 
#nullable restore
#line 33 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                                                  () => userRequest.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "input-group mb-3");
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "placeholder", "Email");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                                                 userRequest.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRequest.Email = __value, userRequest.Email))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRequest.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.AddMarkupContent(59, "<div class=\"input-group-append\">\r\n                            <div class=\"input-group-text\">\r\n                                <span class=\"fa fa-envelope\"></span>\r\n                            </div>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "row");
                __builder2.AddMarkupContent(63, "\r\n");
#nullable restore
#line 44 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                         if (IsSearching)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                            ");
                __builder2.AddMarkupContent(65, @"<button type=""submit"" class=""btn btn-block btn-primary"" disabled>
                                <span class=""fa fa-refresh fas spinning"" style=""margin-right:10px;""></span>
                                Request New Password
                            </button>
");
#nullable restore
#line 50 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(66, "                            ");
                __builder2.AddMarkupContent(67, "<button type=\"submit\" class=\"btn btn-block btn-primary\">\r\n                                Request New Password\r\n                            </button>\r\n");
#nullable restore
#line 56 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "                        \r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n\r\n                ");
            __builder.AddMarkupContent(71, "<p class=\"mt-3 mb-1\">\r\n                    <a href=\"/login\">Login</a>\r\n                </p>\r\n                ");
            __builder.AddMarkupContent(72, "<p class=\"mb-0\">\r\n                    <a href=\"/register\" class=\"text-center\">I Don\'t Have an Account</a>\r\n                </p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Forgetpassword.razor"
       

    private ForgetPasswordRequest userRequest = new ForgetPasswordRequest();

    bool loginFailure;

    private bool IsSearching { get; set; }

    private string ErrorMessage = null;

    protected async override Task OnInitializedAsync()
    {
        await _loginService.Logout();
    }

    private async Task ForgetPassword()
    {
        IsSearching = true;

        StateHasChanged();

        var userToken = await _accountService.ForgetPassword(userRequest);

        loginFailure = userToken.Result == null;


        if (!loginFailure)
        {
            ErrorMessage = userToken.Result;
            IsSearching = false;
            userRequest.Email = null;
            StateHasChanged();
        }
        else
        {
            ErrorMessage = userToken.Error;
            IsSearching = false;
            userRequest.Email = null;
            StateHasChanged();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService _loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccount _accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditBody _editbodyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatroom _chatroomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChapter _chapterService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvitee _inviteeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITopics _topicsService { get; set; }
    }
}
namespace __Blazor.Project_Management_System.Client.Pages.UsersAuth.Forgetpassword
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
