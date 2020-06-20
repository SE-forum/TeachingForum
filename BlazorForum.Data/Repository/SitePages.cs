using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorForum.Models;

namespace BlazorForum.Data.Repository
{
    public class SitePages
    {
        private readonly ApplicationDbContext _context;

        public SitePages(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SitePage> GetIndexPageAsync()
        {
            await CreatePageIfNoneFound();
            return await _context.Pages.Where(p => p.IsIndex == true).FirstOrDefaultAsync();
        }

        public async Task<SitePage> GetPageAsync(int pageId)
        {
            return await _context.Pages.Where(p => p.SitePageId == pageId).FirstOrDefaultAsync();
        }

        public async Task<List<SitePage>> GetPagesAsync()
        {
            return await _context.Pages.ToListAsync();
        }

        public async Task<bool> UpdatePageAsync(SitePage editedPage)
        {
            var page = await _context.Pages.Where(p => p.SitePageId == editedPage.SitePageId).FirstOrDefaultAsync();
            if(page != null)
            {
                page.Title = editedPage.Title;
                page.MainContent = editedPage.MainContent;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        private async Task CreatePageIfNoneFound()
        {
            // This is mostly used for the very first page visit after a fresh install.
            var pages = await _context.Pages.ToListAsync();
            if (pages.Count == 0)
            {
                var page = new SitePage
                {
                    Title = "欢迎页",
                    MainContent = "<p>欢迎来到论坛" +
                    "可以点击\"版面\"进行看帖、发帖;点击右上角用户名，可进行个人信息管理</p><p>若你是老师，还可以点击\"管理论坛\"进行管理</p>",
                    IsIndex = true,
                    AllowDelete = false
                };
                await _context.Pages.AddAsync(page);
                await _context.SaveChangesAsync();
            }
        }
    }
}
