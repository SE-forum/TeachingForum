#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dff9a529971ae31ed44d33951b960a818967dc7"
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
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.JSInterop;

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
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

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
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
using BlazorForum.Pages.Components.UpDownVote;

#line default
#line hidden
    public partial class Post : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "forum-post-container");
            __builder.AddMarkupContent(2, "\n");
#line 5 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
     if (!_isEditorVisible && ForumUpDownVoteEnabled)
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenComponent<BlazorForum.Pages.Components.UpDownVote.UpDownVote>(4);
            __builder.AddAttribute(5, "PostId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                             ThisPost.ForumPostId

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "UniqueIdentifier", "ForumPost");
            __builder.AddAttribute(7, "PosterId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                           ThisPost.UserId

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "VoterId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                                                      CurrentUserId

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n");
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "forum-post-content" + " " + (
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                     _isEditorVisible ? "w-100" : ""

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\n");
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
         if (_isEditorVisible == false)
            

#line default
#line hidden
            __builder.AddContent(14, 
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
              (MarkupString)ThisPost.PostText

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\n");
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
         if (ThisPost.UserId == CurrentUserId)
        {
            if (_isEditorVisible == true)
            {

#line default
#line hidden
            __builder.AddContent(16, "                ");
            __builder.OpenComponent<BlazorForum.Pages.Components.Forums.PostForm>(17);
            __builder.AddAttribute(18, "OnPostUpdated", new System.Action(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                           () => HideThisEditor()

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "CurrentUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                    CurrentUserId

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "PostToEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorForum.Models.ForumPost>(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                                                ThisPost

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "OnCancel", new System.Action(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                                                                      () => HideThisEditor()

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
#line 19 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
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
#line 23 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                                                                                              () => _isEditorVisible = true

#line default
#line hidden
            ));
            __builder.AddMarkupContent(30, "编辑");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#line 25 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
            }
        }

#line default
#line hidden
            __builder.AddMarkupContent(33, "\n");
#line 28 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
         if (_isEditorVisible == false)
        {

#line default
#line hidden
            __builder.AddContent(34, "            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "forum-post-time d-inline-block");
            __builder.AddMarkupContent(37, "\n                Posted ");
            __builder.AddContent(38, 
#line 31 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                        DateTimeFormatting.RelativeDateAgo(ThisPost.PostedDate)

#line default
#line hidden
            );
            __builder.AddMarkupContent(39, "\n                by ");
            __builder.AddContent(40, 
#line 32 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                    ThisPost.UserName

#line default
#line hidden
            );
            __builder.AddMarkupContent(41, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#line 34 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
             if (ThisPost.EditedDate != null)
            {

#line default
#line hidden
            __builder.AddContent(43, "                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "forum-post-time ml-3 d-inline-block");
            __builder.AddMarkupContent(46, "\n                    Edited ");
            __builder.AddContent(47, 
#line 37 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
                            DateTimeFormatting.RelativeDateAgo(Convert.ToDateTime(ThisPost.EditedDate))

#line default
#line hidden
            );
            __builder.AddMarkupContent(48, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#line 39 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
            }

#line default
#line hidden
#line 39 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 44 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\SubComponents\Post.razor"
       
    [Parameter] public string CurrentUserId { get; set; }
    [Parameter] public ForumPost ThisPost { get; set; }
    [Parameter] public int ForumId { get; set; }
    [Parameter] public bool ForumUpDownVoteEnabled { get; set; }
    private bool _isEditorVisible = false;

    private void HideThisEditor()
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
