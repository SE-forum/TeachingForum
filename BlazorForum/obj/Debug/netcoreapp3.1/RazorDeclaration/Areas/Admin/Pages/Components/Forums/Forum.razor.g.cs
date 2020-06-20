#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f557730602c1655497baf187a923c79c07954ebf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForum.Areas.Admin.Pages.Components.Forums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

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
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{id:int}")]
    public partial class Forum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 49 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
       
    [Parameter] public int id { get; set; }
    private Models.Forum forum = new Models.Forum();
    private List<Models.ForumCategory> categories = new List<Models.ForumCategory>();

    protected override async Task OnInitializedAsync()
    {
        forum = await manageForums.GetForumAsync(id);
        categories = await manageCategories.GetForumCategoriesAsync(id);

        blazorModal.OnConfirmDeleteForum += DeleteForumConfirmed;
    }

    public void Dispose()
    {
        blazorModal.OnConfirmDeleteForum -= DeleteForumConfirmed;
    }

    public async void UpdateCategories()
    {
        categories = await manageCategories.GetForumCategoriesAsync(id);
        StateHasChanged();
    }

    private void DeleteClicked()
    {
        var modalMessage = "你确定要删除版面吗？这同时会删除掉相关的子版块、话题、帖子";
        blazorModal.Show<ConfirmModal>("删除版面", BlazorModalParameter.Get("ModalText", modalMessage),
            BlazorModalParameter.Get("ItemToDelete", "forum"));
    }

    public async void DeleteForumConfirmed()
    {
        blazorModal.Close();
        var deleted = await manageForums.DeleteForumAsync(id);
        if (deleted)
            navManager.NavigateTo("/admin/manage/forums");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorModal blazorModal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumCategories manageCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
    }
}
#pragma warning restore 1591