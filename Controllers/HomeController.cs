using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.DAL.Interfaces;
using Shop.Domain.Entity;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        ////private readonly ILogger<HomeController> _logger;

        //public HomeController(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}

        public async Task<IActionResult> Index() //было IndexAsync()
        {
            //var response = await _productRepository.Select();
            //Product product = new Product()
            //{
            //    Id = 1,
            //    NameProduct = "Ручка"


            //};
            //return View(product);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
