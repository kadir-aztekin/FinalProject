using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //INSANLAR BIZE NASIL ULASSSIN DEMEK CHROME DA  HANİ APİ/PRODUCTS YAZDIGIMIZ YERIN TANIMI 
    [ApiController]  // ATTRIBUTE DENİR : BİR CLASS İLGİLİ BİLGİ VERME YONTEMİDİR 
    public class ProductsController : ControllerBase
    {
        //Constructor 
        //IoC Container -Inversıon of Control 
        //IoC containerii biz startup da tanımlayabildik AddSingleton da tanımladık
        IProductService _productService;


        //Loosely Coupling --Gevsek Bagımlılık 
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] //select * from ıslemı gıbı dusun 
        public IActionResult GetAll()
        {

            //Dependency chain --Bagımlılık zıncırı 
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyıd")] 
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")] //ekleme(add) silme(delete) update ıslemleri  gıbı

        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost ("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
} 
