using Nop.Services.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace AO.FrilivTransfers
{
    public class App : IApp
    {
        private readonly IProductService _productService;

        public App(IProductService productService)
        {
            _productService = productService;
        }

        public void InitiateService()
        {
            Console.WriteLine("Service ready");
            var product = _productService.GetProductById(1);
        }
    }
}
