#pragma checksum "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Chapters\Yourchapter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20df8262dc054679514b204ec67ad26950d77c79"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project_Management_System.Client.Pages.Chapters
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
#line 3 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/{topicsId:guid}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/{topicsId:guid}/{chapterId:guid}")]
    public partial class Yourchapter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "C:\Users\olowoyinka\source\repos\BLAZOR\Project_Management_System\Project_Management_System\Client\Pages\Chapters\Yourchapter.razor"
      

    BlazoredTextEditor QuillHtml;

    [Parameter]
    public Guid topicsId { get; set; }

    [Parameter]
    public Guid chapterId { get; set; }

    [Parameter]
    public TopicsResponse topicsResponse { get; set; } = new TopicsResponse();

    [Parameter]
    public UsernameResponse username { get; set; } = new UsernameResponse();

    [Parameter]
    public string usernameRole { get; set; }

    ChapterByIdResponse chapterByIdResponse = new ChapterByIdResponse();

    CancellationTokenSource pollingCancellationToken;

    private DateTime currentDate;

    private bool IsSearching { get; set; }

    bool Failure;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            topicsResponse = await _topicsService.GetByIdAsync(topicsId);

            if(topicsResponse.Name == null)
            {
                NavigationManager.NavigateTo("/notfound");
            }

            username = await _accountService.GetUser();

            usernameRole = topicsResponse.SingleUsernameResponse.UserName;
        }
        catch (Exception ex)
        {

        }
    }


    protected async override Task OnParametersSetAsync()
    {
        chapterByIdResponse = await _editbodyService.GetByIdAsync(topicsId, chapterId);

        await QuillHtml.LoadContent(chapterByIdResponse.Body);

        currentDate = chapterByIdResponse.CreatedDate;

        pollingCancellationToken?.Cancel();

        UpdatesBody();

        await js.ModalClose();
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await js.textEnterButton();
        }
    }


    private async void UpdatesBody()
    {
        pollingCancellationToken = new CancellationTokenSource();

        while (!pollingCancellationToken.IsCancellationRequested)
        {
            try
            {

                string ErrorMessage;
                IsSearching = true;
                StateHasChanged();

                ChapterEditRequest chapterEditRequest = new ChapterEditRequest();

                chapterEditRequest.Body = await QuillHtml.GetContent();

                var result = await _editbodyService.UpdateBodyAsync(topicsId, chapterId, chapterEditRequest);

                Failure = result.Token == null;

                ErrorMessage = result.Error;

                if (ErrorMessage != null)
                {
                    await js.RemoveModal("Unable to Updated", $"{chapterByIdResponse.Name}", SweetAlertMessageType.error);
                }

                currentDate = DateTime.Now;

                IsSearching = false;
                StateHasChanged();
            }
            catch (Exception ex)
            {
                pollingCancellationToken.Cancel();

                Console.Error.WriteLine(ex);
            }

            StateHasChanged();

            await Task.Delay(100000);
        }

    }


    private async Task SaveBody()
    {
        string ErrorMessage;
        IsSearching = true;
        StateHasChanged();

        ChapterEditRequest chapterEditRequest = new ChapterEditRequest();

        chapterEditRequest.Body = await QuillHtml.GetContent();

        var result = await _editbodyService.UpdateBodyAsync(topicsId, chapterId, chapterEditRequest);

        Failure = result.Token == null;

        ErrorMessage = result.Error;

        if (ErrorMessage != null)
        {
            await js.RemoveModal("Unable to Update", $"{chapterByIdResponse.Name}", SweetAlertMessageType.error);
        }

        currentDate = DateTime.Now;

        IsSearching = false;
        StateHasChanged();
    }

    void IDisposable.Dispose()
    {
        pollingCancellationToken?.Cancel();
    }


#line default
#line hidden
#nullable disable
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
#pragma warning restore 1591
