#pragma checksum "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543f44bd8b40d4cd0afde0fc08a4090dd64b49e8"
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
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Respository.RespositoryInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.UserRequest;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoNavBar))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(6, "<div class=\"login-logo\">\r\n            <a href=\"/login\"><b>Proj</b>MAN</a>\r\n        </div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body login-card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h4 class=\"login-box-msg\">Sign In</h4>\r\n");
#nullable restore
#line 16 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
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
#line 20 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
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
#line 23 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                 }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(25);
            __builder.AddAttribute(26, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                 userRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                                             LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "text-danger");
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __Blazor.Project_Management_System.Client.Pages.UsersAuth.Login.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line 27 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                                  () => userRequest.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "input-group mb-3");
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "placeholder", "Username");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                                 userRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRequest.UserName = __value, userRequest.UserName))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.AddMarkupContent(49, "<div class=\"input-group-append\">\r\n                            <div class=\"input-group-text\">\r\n                                <span class=\"fa fa-user\"></span>\r\n                            </div>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "text-danger");
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __Blazor.Project_Management_System.Client.Pages.UsersAuth.Login.TypeInference.CreateValidationMessage_1(__builder2, 54, 55, 
#nullable restore
#line 38 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                                  () => userRequest.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "input-group mb-3");
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenComponent<Project_Management_System.Client.Shared.InputPassword>(61);
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                                                                          userRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRequest.Password = __value, userRequest.Password))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userRequest.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.AddMarkupContent(67, "<div class=\"input-group-append\">\r\n                            <div class=\"input-group-text\">\r\n                                <span class=\"fa fa-lock\"></span>\r\n                            </div>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "social-auth-links text-center mb-3");
                __builder2.AddMarkupContent(71, "\r\n");
#nullable restore
#line 50 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                         if (IsSearching)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "                            ");
                __builder2.AddMarkupContent(73, "<button type=\"submit\" class=\"btn btn-block btn-primary\" disabled><span class=\"fa fa-refresh fas spinning\" style=\"margin-right:10px;\"></span>\r\n                                Sign In\r\n                            </button>\r\n");
#nullable restore
#line 55 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(74, "                            ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-block btn-primary\">\r\n                                Sign In\r\n                            </button>\r\n");
#nullable restore
#line 61 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n\r\n\r\n                ");
            __builder.AddMarkupContent(79, "<p class=\"mb-1\">\r\n                    <a href=\"/forgetpassword\">I forgot my password</a>\r\n                </p>\r\n                ");
            __builder.AddMarkupContent(80, "<p class=\"mb-0\">\r\n                    <a href=\"/register\" class=\"text-center\">I Don\'t Have an Account</a>\r\n                </p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Pages\UsersAuth\Login.razor"
       

    private LoginUserRequest userRequest = new LoginUserRequest();

    bool loginFailure;

    private bool IsSearching { get; set; }

    private string ErrorMessage = null;

    protected async override Task OnInitializedAsync()
    {
        await _loginService.Logout();
    }

    private async Task LoginUser()
    {
        IsSearching = true;

        StateHasChanged();

        var userToken = await _accountService.Login(userRequest);

        loginFailure = userToken.Token == null;

        if (!loginFailure)
        {
            await _loginService.Login(userToken.Token);

            _navigationManager.NavigateTo("/");
        }

        ErrorMessage = userToken.Error;

        IsSearching = false;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService _loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccount _accountService { get; set; }
    }
}
namespace __Blazor.Project_Management_System.Client.Pages.UsersAuth.Login
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
