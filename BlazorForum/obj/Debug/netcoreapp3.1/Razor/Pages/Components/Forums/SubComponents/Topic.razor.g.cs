#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620b98621dfa6b7b7e8fa19bea09da801fa334b3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Pages.Components.Forums.SubComponents
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
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
using BlazorForum.Pages.Components.UpDownVote;

#line default
#line hidden
    public partial class Topic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "forum-topic-container");
            __builder.AddMarkupContent(2, "\n");
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
     if (!_isEditorVisible && ForumUpDownVoteEnabled)
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenComponent<BlazorForum.Pages.Components.UpDownVote.UpDownVote>(4);
            __builder.AddAttribute(5, "PostId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                             ThisTopic.ForumTopicId

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "UniqueIdentifier", "ForumTopic");
            __builder.AddAttribute(7, "PosterId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                                              ThisTopic.UserId

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "VoterId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                                                                          CurrentUserId

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n");
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "forum-topic-content" + " " + (
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                      _isEditorVisible ? "w-100" : ""

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\n");
#line 11 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
         if (_isEditorVisible != true)
            

#line default
#line hidden
            __builder.AddContent(14, 
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
              (MarkupString)ThisTopic.TopicText

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\n");
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
         if (ThisTopic.UserId == CurrentUserId)
        {
            

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
             if (_isEditorVisible)
            {

#line default
#line hidden
            __builder.AddContent(16, "                ");
            __builder.OpenComponent<BlazorForum.Pages.Components.Forums.TopicForm>(17);
            __builder.AddAttribute(18, "OnTopicUpdated", new System.Action(
#line 18 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                            RefreshTopic

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "CurrentUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                          CurrentUserId

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "ForumTopicToEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorForum.Models.ForumTopic>(
#line 18 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                                                            ThisTopic

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "OnCancel", new System.Action(
#line 18 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                                                                                  RefreshTopic

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
#line 19 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-sm btn-blazorforum mb-2");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
                                                                                              () => _isEditorVisible = true

#line default
#line hidden
            ));
            __builder.AddMarkupContent(30, "编辑");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#line 25 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
            }

#line default
#line hidden
#line 25 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Pages\Components\Forums\SubComponents\Topic.razor"
       
    [Parameter] public Models.ForumTopic ThisTopic { get; set; }
    [Parameter] public bool ForumUpDownVoteEnabled { get; set; }
    [Parameter] public string CurrentUserId { get; set; }
    private bool _isEditorVisible = false;

    private void RefreshTopic()
    {
        _isEditorVisible = false;
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
    }
}
#pragma warning restore 1591