using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Repositories;
using Shop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }



        [HttpGet] //атрибут на метод действия
        public async Task<IActionResult> GetProducts()
        {
            var response = await _productRepository.Select(); //было var response = await _carRepository.Select();
            var response1 = await _productRepository.GetByNameAsync("Ручка");//var response1 = await _carRepository.GetByName("Ручка");
            var response2 = await _productRepository.GetAsync(3);// var response2 =  _carRepository.GetAsync(3);
            var responseSelect = await _productRepository.GetAsyncSelect(); //----->> 150824
            //var resultJ = await _resultJoinRepository.GetResultJoin();

            //var product = new Product()
            //{

            //    NameProduct = "VAZ 2114",
            //    IdNameCategory = 3

            //};

            //await _productRepository.Create(product); //var response3 =  await _carRepository.Create(car);
            //await _productRepository.Delete(product);

            return View(responseSelect); //response будт храниться писок объектов из нашей бд
        }
    }



    
}
