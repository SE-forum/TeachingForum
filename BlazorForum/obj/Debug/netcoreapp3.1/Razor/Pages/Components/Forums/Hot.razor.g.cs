#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ee416d05bd7012cf518e1cd9d5c531bfce8e53"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Pages.Components.Forums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/Hot")]
    public partial class Hot : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
 if (_topics == null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mb-2 loading-div");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "em");
            __builder.AddMarkupContent(5, "<i class=\"oi oi-cog se-spin-icon\"></i> ");
            __builder.AddContent(6, 
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                                                    GeneralResources.Loading

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
}
else
{
    

#line default
#line hidden
#line 21 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
     if (_topics.Count == 0)
    {

#line default
#line hidden
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "alert alert-secondary");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "text-secondary");
            __builder.AddContent(15, 
#line 24 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                                          GeneralResources.NoForumsFound

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
    }

#line default
#line hidden
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
     
    foreach (var topic in _topics)
    {

#line default
#line hidden
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mb-2");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "header");
            __builder.AddAttribute(23, "class", "forum-header");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, 
#line 31 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                     topic.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n            ");
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "forum-ul");
            __builder.AddMarkupContent(31, "\r\n\r\n                ");
            __builder.OpenElement(32, "li");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", 
#line 37 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                              String.Format("/topic/{0}/{1}",
                        topic.ForumTopicId, UrlFormatting.PrepareUrlText(topic.ForumTopicUrl))

#line default
#line hidden
            );
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.AddContent(37, 
#line 39 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                         topic.Title

#line default
#line hidden
            );
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ( ");
            __builder.AddContent(40, 
#line 41 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                       topic.Flags

#line default
#line hidden
            );
            __builder.AddMarkupContent(41, " )\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "topic-blazifier");
            __builder.AddMarkupContent(44, "\r\n                        Posted ");
            __builder.AddContent(45, 
#line 43 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                                Domain.Utilities.Formatting.DateTimeFormatting.RelativeDateAgo(topic.PostedDate)

#line default
#line hidden
            );
            __builder.AddMarkupContent(46, "\r\n                        by ");
            __builder.AddContent(47, 
#line 44 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
                            topic.UserName

#line default
#line hidden
            );
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#line 51 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 54 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Hot.razor"
       
    private List<Models.ForumTopic> _topics;
    private List<TopicPostCount> _topicCountList = new List<TopicPostCount>();

    protected override async Task OnInitializedAsync()
    {
        head.Title = "Topics";
        _topics = await manageTopics.GetAllApprovedForumTopicsAsync_order();
        await AddUserToTopicAsync();
    }
    private async Task AddUserToTopicAsync()
    {
        foreach (var topic in _topics)
        {
            var user = await userManager.FindByIdAsync(topic.UserId);
            topic.UserName = user.UserName;
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageTopics { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumCategories manageCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591
