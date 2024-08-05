using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents._AdminLayout
{
    public class _AdminLayoutHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
