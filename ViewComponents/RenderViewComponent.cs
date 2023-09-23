using Lap1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lap1.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();
        public RenderViewComponent() 
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem(){Id = 1, Name = "Bran", Link = "Bran/List"},
                new MenuItem(){Id = 2, Name = "Stu", Link = "Stu/List"},
                new MenuItem(){Id = 3,Name = "Subj", Link = "Subj/List"},
                new MenuItem(){Id = 4,Name = "Cour", Link = "Cour/List"}
            };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
