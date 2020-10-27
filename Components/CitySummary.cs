﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebApp.Models;

namespace WebApp.Components
{
    public class CitySummary: ViewComponent
    {
        private CitiesData data;
        public CitySummary(CitiesData cdata)
        {
            data = cdata;
        }
        public string Invoke()
        {
            if (RouteData.Values["controller"] != null)
            {
                return "Controller Request";
            }
            else
            {
                return "Razor Page Request";
            }
        }
    }
}
