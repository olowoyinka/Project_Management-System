#pragma checksum "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f818100bf91264a07265591955d384e3410ea15e"
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
#line 1 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Pages.UsersAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.Respository.RespositoryInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Project_Management_System.Client.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.UserRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.ViewModelResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Request.ViewModelRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using EndPoint.Response.UserResponse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\olowoyinka\source\repos\Project_Management_System\Project_Management_System\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"main-header navbar navbar-expand navbar-light navbar-white\">\r\n\r\n    <ul class=\"navbar-nav\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" data-widget=\"pushmenu\" href=\"#\" role=\"button\"><i class=\"fa fa-bars\"></i></a>\r\n        </li>\r\n    </ul>\r\n\r\n    <form class=\"form-inline ml-3\">\r\n        <div class=\"input-group input-group-sm\">\r\n            <input class=\"form-control form-control-navbar\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n            <div class=\"input-group-append\">\r\n                <button class=\"btn btn-navbar\" type=\"submit\">\r\n                    <i class=\"fa fa-search\"></i>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </form>\r\n\r\n    <ul class=\"navbar-nav ml-auto\">\r\n        <li class=\"nav-item dropdown\">\r\n            <a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\">\r\n                <i class=\"fa fa-bell\"></i>\r\n                <span class=\"badge badge-warning navbar-badge\">15</span>\r\n            </a>\r\n            <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\">\r\n                <span class=\"dropdown-item dropdown-header\">15 Notifications</span>\r\n                <div class=\"dropdown-divider\"></div>\r\n                <a href=\"#\" class=\"dropdown-item\">\r\n                    <i class=\"fa fa-envelope mr-2\"></i> 4 new messages\r\n                    <span class=\"float-right text-muted text-sm\">3 mins</span>\r\n                </a>\r\n                <div class=\"dropdown-divider\"></div>\r\n                <a href=\"#\" class=\"dropdown-item dropdown-footer\">See All Notifications</a>\r\n            </div>\r\n        </li>\r\n        <li class=\"nav-item dropdown\">\r\n            <a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\">\r\n                <i class=\"fa fa-user\"></i>\r\n                <span class=\"badge badge-danger navbar-badge\">3</span>\r\n            </a>\r\n            <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\">\r\n                <a href=\"#\" class=\"dropdown-item\">\r\n                    <div class=\"media\">\r\n                        <img src alt=\"User Avatar\" class=\"img-size-50 mr-3 img-circle\">\r\n                        <div class=\"media-body\">\r\n                            <h3 class=\"dropdown-item-title\">\r\n                                Brad Diesel\r\n                                <span class=\"float-right text-sm text-danger\"><i class=\"fa fa-star\"></i></span>\r\n                            </h3>\r\n                            <p class=\"text-sm\">Call me whenever you can...</p>\r\n                            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n                <div class=\"dropdown-divider\"></div>\r\n                <a href=\"#\" class=\"dropdown-item dropdown-footer\">See All Messages</a>\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</nav>\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<aside class=\"main-sidebar sidebar-dark-primary elevation-4\" style=\"height:110vh; position:fixed\">\r\n    <a href=\"../../index3.html\" class=\"brand-link\">\r\n        <img src=\"/Images/AdminLTELogo.png\" alt=\"AdminLTE Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n        <span class=\"brand-text font-weight-light\"><strong>ProjMAN</strong></span>\r\n    </a>\r\n    <br>\r\n    <br>\r\n    <div class=\"sidebar\">\r\n        <div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\r\n            <div class=\"image\">\r\n                <img src=\"/Images/love.jpg\" class=\"img-circle elevation-2\" alt=\"User Image\">\r\n            </div>\r\n            <div class=\"info\">\r\n                <a href=\"#\" class=\"d-block\">Inofe Love</a>\r\n            </div>\r\n        </div>\r\n\r\n        <nav class=\"mt-2\">\r\n            <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n                <li class=\"nav-item\">\r\n                    <a href=\"../widgets.html\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-tachometer\"></i>\r\n                        <p>\r\n                            Dashboard\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-header\"></li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"../widgets.html\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-product-hunt\"></i>\r\n                        <p>\r\n                            Projects\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-header\"></li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"../widgets.html\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fa fa-cogs\"></i>\r\n                        <p>\r\n                            Settings\r\n                        </p>\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</aside>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
