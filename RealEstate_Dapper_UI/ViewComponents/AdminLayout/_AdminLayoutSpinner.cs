﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }
    }
}
