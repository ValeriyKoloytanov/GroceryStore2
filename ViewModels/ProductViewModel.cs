﻿using Microsoft.AspNetCore.Http;

namespace DemoStore.ViewModels
{
    public class ProductViewModel
    {
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }

        public IFormFile ProfileImage { get; set; }
    }
}