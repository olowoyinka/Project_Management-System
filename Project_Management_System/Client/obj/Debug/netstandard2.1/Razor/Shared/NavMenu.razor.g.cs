#pragma checksum "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81ee761d41dc3df332897c1d5bcb5852287424b"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_Management_System.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Pages.UsersAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Respository.RespositoryInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Shared.Models.ChatModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.UserRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.ViewModelResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.ViewModelRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.UserResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "main-header navbar navbar-expand navbar-light navbar-white");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<ul class=\"navbar-nav\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" data-widget=\"pushmenu\" href=\"#\" role=\"button\"><i class=\"fa fa-bars\"></i></a>\r\n        </li>\r\n    </ul>\r\n\r\n    ");
            __builder.AddMarkupContent(4, @"<form class=""form-inline ml-3"">
        <div class=""input-group input-group-sm"">
            <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
            <div class=""input-group-append"">
                <button class=""btn btn-navbar"" type=""submit"">
                    <i class=""fa fa-search""></i>
                </button>
            </div>
        </div>
    </form>
    
    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<Project_Management_System.Client.Shared.Notification>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, @"<li class=""nav-item dropdown"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                <i class=""fa fa-user""></i>
            </a>
            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                <div class=""dropdown-divider""></div>
                <a href=""/settings"" class=""dropdown-item"">
                    <i class=""fa fa-cog mr-2""></i> Settings
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""/logout"" class=""dropdown-item"">
                    <i class=""fa fa-sign-out mr-2""></i> Log Out
                </a>
            </div>
        </li>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(13, "<aside class=\"main-sidebar sidebar-dark-primary elevation-4\" style=\"height:110vh; position:fixed\">\r\n    <a href=\"../../index3.html\" class=\"brand-link\">\r\n        <img src=\"/Images/AdminLTELogo.png\" alt=\"AdminLTE Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n        <span class=\"brand-text font-weight-light\"><strong>ProjMAN</strong></span>\r\n    </a>\r\n    <br>\r\n    <br>\r\n    <div class=\"sidebar\">\r\n        <div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\r\n            <div class=\"image\">\r\n                <img src=\"/Images/love.jpg\" class=\"img-circle elevation-2\" alt=\"User Image\">\r\n            </div>\r\n            <div class=\"info\">\r\n                <a href=\"#\" class=\"d-block\">Inofe Love</a>\r\n            </div>\r\n        </div>\r\n\r\n        <nav class=\"mt-2\">\r\n            <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n                <li class=\"nav-item\">\r\n                    <a href=\"/\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-tachometer\"></i>\r\n                        <p>\r\n                            Dashboard\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-header\"></li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"/projects\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-product-hunt\"></i>\r\n                        <p>\r\n                            Projects\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-header\"></li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"/settings\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-cogs\"></i>\r\n                        <p>\r\n                            Settings\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</aside>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccount _accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
