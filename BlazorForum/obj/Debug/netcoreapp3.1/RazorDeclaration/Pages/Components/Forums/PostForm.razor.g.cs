#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\PostForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac75293cf6f32b9f533328f2bac640cf1632786"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForum.Pages.Components.Forums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 18 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    public partial class PostForm : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 35 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\PostForm.razor"
       
    [Parameter] public string CurrentUserId { get; set; }
    [Parameter] public Action OnPostAdded { get; set; }
    [Parameter] public Action OnPostUpdated { get; set; }
    [Parameter] public Action OnCancel { get; set; }
    [Parameter] public Models.ForumPost PostToEdit { get; set; }
    [Parameter] public int TopicId { get; set; }
    [Parameter] public string TopicSlug { get; set; }
    private EditContext _editContext;
    private Models.ForumPost _forumPost = new Models.ForumPost() { UserId = "placeholder" };
    private string _btnVisibility = "d-block";
    private string _submitVisibility = "d-none";

    protected override void OnInitialized()
    {
        if (PostToEdit != null)
            _forumPost = PostToEdit;

        _editContext = new EditContext(_forumPost);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("methods.loadEditor", "PostText-" + _forumPost.ForumPostId);
        }
    }

    public void Dispose()
    {
        jsRuntime.InvokeVoidAsync("methods.removeTargetedEditor", "PostText-" + _forumPost.ForumPostId);
    }

    private async Task AddNewPost()
    {
        _forumPost.PostText = await jsRuntime.InvokeAsync<string>("methods.getTargetedEditorText", "PostText-" + _forumPost.ForumPostId);
        var isValid = _editContext.Validate();
        if (isValid)
        {
            _btnVisibility = "d-none";
            _submitVisibility = "d-inline-block";

            if (PostToEdit != null)
                await UpdatePost();
            else
            {
                await CreatePost();

                _btnVisibility = "d-inline-block";
                _submitVisibility = "d-none";
                _forumPost.PostText = string.Empty;
                await jsRuntime.InvokeVoidAsync("methods.clearTargetedEditor", "PostText-" + _forumPost.ForumPostId);
                StateHasChanged();
            }
        }
    }

    private async Task CreatePost()
    {
        var newPost = new Models.ForumPost()
        {
            PostText = _forumPost.PostText,
            UserId = CurrentUserId,
            PostedDate = DateTime.Now.ToUniversalTime(),
            ForumTopicId = TopicId,
            Flags = 0,
            IsModeratorChanged = false,
            IsDeleted = false,
            IsApproved = true,
            //UserIP = httpContext.HttpContext.Connection.RemoteIpAddress.ToString() // Issues with this failing on server
        };

        var posted = await manageForumPosts.AddNewPostAsync(newPost);

        if (posted)
        {
            await new Domain.Helpers.Forum.AddPostHelpers(manageTopicSubscriptions, manageForumTopics, httpContextAccessor, userManager, emailSender)
                .AddSubscriptionAndSendEmailToSubscribers(TopicId, CurrentUserId, TopicSlug);

            OnPostAdded?.Invoke();
        }
    }

    private async Task UpdatePost()
    {
        var editedPost = new Models.ForumPost
        {
            ForumPostId = _forumPost.ForumPostId,
            PostText = _forumPost.PostText,
            UserId = _forumPost.UserId,
            PostedDate = _forumPost.PostedDate,
            ForumTopicId = _forumPost.ForumTopicId,
            Flags = _forumPost.Flags,
            IsModeratorChanged = _forumPost.IsModeratorChanged,
            IsDeleted = _forumPost.IsDeleted,
            IsApproved = _forumPost.IsApproved,
            EditedBy = CurrentUserId,
            EditedDate = DateTime.Now.ToUniversalTime(),
            UserIP = _forumPost.UserIP
        };

        var updated = await manageForumPosts.UpdatePostAsync(editedPost);

        if (updated)
        {
            await jsRuntime.InvokeVoidAsync("methods.removeTargetedEditor", "PostText-" + _forumPost.ForumPostId);
            OnPostUpdated?.Invoke();
        }
    }

    private async void CancelUpdate()
    {
        await jsRuntime.InvokeVoidAsync("methods.removeTargetedEditor", "PostText-" + _forumPost.ForumPostId);
        OnCancel?.Invoke();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageTopicSubscriptions manageTopicSubscriptions { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Identity.UI.Services.IEmailSender emailSender { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageForumTopics { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumPosts manageForumPosts { get; set; }
    }
}
#pragma warning restore 1591