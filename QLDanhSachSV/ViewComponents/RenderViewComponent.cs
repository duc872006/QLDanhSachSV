
using Microsoft.AspNetCore.Mvc;
using QLDanhSachSV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLDanhSachSV.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private readonly List<MenuItem> MenuItems = new List<MenuItem>
        {
            new MenuItem
            {
                Id = 1,
                Name = "Trang chủ",
                Link = "/Home/Index"
            },
            new MenuItem
            {
                Id = 2,
                Name = "Danh sách sinh viên",
                Link = "/Student/Index"
            },
            new MenuItem
            {
                Id = 3,
                Name = "Thêm sinh viên",
                Link = "/Student/Create"
            }
        };

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
