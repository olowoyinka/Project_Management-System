#pragma checksum "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66432c6d1ad4a4e6c0c7eb4019fbaeb79a22d2a"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_Management_System.Client.Pages.Settings
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
#nullable restore
#line 3 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/changeprofile")]
    public partial class ChangeName : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "content-header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "content");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-3");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenComponent<Project_Management_System.Client.Pages.Settings.SideBar>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-8");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card card-outline card-primary");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, @"<div class=""card-header"">
                            <h3 class=""card-title"">
                                Change Profile Name
                            </h3>
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool btn-sm"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                    <i class=""fa fa-minus""></i>
                                </button>
                            </div>
                        </div>
                        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body pad");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-4");
            __builder.AddMarkupContent(33, "\r\n                                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddMarkupContent(36, "\r\n                                        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-12");
            __builder.AddMarkupContent(39, "\r\n                                                ");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 40 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                          imagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "asp-append-version", "true");
            __builder.AddAttribute(43, "class", "img-fluid img-lg img-circle");
            __builder.AddAttribute(44, "alt", "User Image");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-12 mt-3");
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "file");
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                                async () => await UploadProfilePictureAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(53, (__value) => {
#nullable restore
#line 43 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                     inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-12 mt-3 mb-3");
            __builder.AddMarkupContent(58, "\r\n                                            ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "type", "submit");
            __builder.AddAttribute(61, "class", "btn btn-block btn-danger");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                                               () => RemoveProfilePictureAsync(username.Images)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "\r\n                                                <i class=\"nav-icon fa fa-trash\"></i>\r\n                                                Remove Profile Picture\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-8");
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 54 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                     if (Failure)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                                        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "text-danger");
            __builder.AddMarkupContent(74, "\r\n                                            ");
            __builder.OpenElement(75, "h6");
            __builder.AddMarkupContent(76, "\r\n                                                ");
            __builder.AddContent(77, 
#nullable restore
#line 58 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                 ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(78, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 61 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "                                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "mb-3");
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(85);
            __builder.AddAttribute(86, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                          fullNameRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 63 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                          SaveName

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(89, "\r\n                                            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "row");
                __builder2.AddMarkupContent(92, "\r\n                                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(93);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n                                                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-md-12");
                __builder2.AddMarkupContent(97, "\r\n                                                    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddMarkupContent(100, "\r\n                                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(101);
                __builder2.AddAttribute(102, "class", "form-control");
                __builder2.AddAttribute(103, "disabled", true);
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                 fullNameRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fullNameRequest.UserName = __value, fullNameRequest.UserName))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fullNameRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n                                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                                ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-md-12");
                __builder2.AddMarkupContent(112, "\r\n                                                    ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddMarkupContent(115, "\r\n                                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(116);
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "placeholder", "First Name");
                __builder2.AddAttribute(119, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                 fullNameRequest.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fullNameRequest.FirstName = __value, fullNameRequest.FirstName))));
                __builder2.AddAttribute(121, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fullNameRequest.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n                                                        ");
                __Blazor.Project_Management_System.Client.Pages.Settings.ChangeName.TypeInference.CreateValidationMessage_0(__builder2, 123, 124, 
#nullable restore
#line 74 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                  () => fullNameRequest.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(125, "\r\n                                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n\r\n                                                ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "col-md-12");
                __builder2.AddMarkupContent(130, "\r\n                                                    ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group");
                __builder2.AddMarkupContent(133, "\r\n                                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(134);
                __builder2.AddAttribute(135, "class", "form-control");
                __builder2.AddAttribute(136, "placeholder", "Last Name");
                __builder2.AddAttribute(137, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                 fullNameRequest.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fullNameRequest.LastName = __value, fullNameRequest.LastName))));
                __builder2.AddAttribute(139, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fullNameRequest.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n                                                        ");
                __Blazor.Project_Management_System.Client.Pages.Settings.ChangeName.TypeInference.CreateValidationMessage_1(__builder2, 141, 142, 
#nullable restore
#line 81 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                                                  () => fullNameRequest.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(143, "\r\n                                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n\r\n                                                ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "modal-footer");
                __builder2.AddMarkupContent(148, "\r\n");
#nullable restore
#line 86 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                     if (IsSearching)
                                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(149, "                                                        ");
                __builder2.AddMarkupContent(150, "<button type=\"submit\" class=\"btn btn-block btn-success\" disabled><span class=\"fa fa-refresh fas spinning\" style=\"margin-right:10px;\"></span>Saving</button>\r\n");
#nullable restore
#line 89 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(151, "                                                        ");
                __builder2.AddMarkupContent(152, "<button type=\"submit\" class=\"btn btn-block btn-success\">Save Changes</button>\r\n");
#nullable restore
#line 93 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
                                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(153, "                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(156, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Settings\ChangeName.razor"
       

    FullNameRequest fullNameRequest = new FullNameRequest();

    UsernameResponse username = new UsernameResponse();

    DeletePictureRequest deletePictureRequest = new DeletePictureRequest();

    ElementReference inputReference;

    string fileName = string.Empty;

    string message = string.Empty;

    string imagePath = null;

    Stream fileStream = null;

    private bool IsSearching { get; set; }

    bool Failure;

    private string ErrorMessage = null;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await GetUser();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task GetUser()
    {
        username = await _accountService.GetUser();

        fullNameRequest.FirstName = username.FirstName;

        fullNameRequest.LastName = username.LastName;

        fullNameRequest.UserName = username.UserName;

        imagePath = $"Images/{username.Images}";
    }


    private async Task SaveName()
    {
        IsSearching = true;

        StateHasChanged();

        var result = await _accountService.ChangeFullName(fullNameRequest);

        await js.RemoveModal("Your Profile Updated", $"", SweetAlertMessageType.success);

        IsSearching = false;

        StateHasChanged();
    }

    async Task UploadProfilePictureAsync()
    {

        var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file == null)
            return;

        var fileInfo = await file.ReadFileInfoAsync();

        fileName = fileInfo.Name;

        using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
        {
            fileStream = new MemoryStream(ms.ToArray());
        }

        var content = new MultipartFormDataContent();

        content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

        content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

        var response = await http.PostAsync("v1/profile", content);

        if (response.IsSuccessStatusCode)
        {
            var uploadedFileName = await response.Content.ReadAsStringAsync();

            imagePath = null;

            imagePath = $"/{uploadedFileName}";
        }
    }

    private async Task RemoveProfilePictureAsync(string username)
    {
        deletePictureRequest.DeleteName = username;

        await http.PostJsonAsync("v1/profiledelete", deletePictureRequest);

        imagePath = $"/Images/noProfile.jpg";

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditBody _editbodyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatroom _chatroomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChapter _chapterService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvitee _inviteeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITopics _topicsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccount _accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Project_Management_System.Client.Pages.Settings.ChangeName
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
