using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OrderTracking.Context;
using OrderTracking.Models;
using OrderTracking.ViewModels;

namespace OrderTracking.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _dbContext;

        public OrderController(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult ColorList()
        {
            var colors = _dbContext.Colors.ToList();

            return Ok(colors);
        }
        [HttpGet]
        public IActionResult CountryList()
        {
            var countries = _dbContext.Countries.ToList();

            return Ok(countries);
        }
        [HttpGet]
        public IActionResult PatternList()
        {
            var patterns = _dbContext.Patterns.ToList();

            return Ok(patterns);
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var products = _dbContext.ProductModels.ToList();

            return Ok(products);
        }
        [HttpGet]
        public IActionResult SizeSetList()
        {
            var sizeSets = _dbContext.SizeSets.ToList();

            return Ok(sizeSets);
        }
        [HttpGet]
        public IActionResult SeasonList()
        {
            var seasons = _dbContext.Seasons.ToList();

            return Ok(seasons);
        }
        [HttpGet]
        public IActionResult SizeList()
        {
            var sizes = _dbContext.Sizes.ToList();

            return Ok(sizes);
        }
        [HttpGet]
        public IActionResult SizeSetSizeList()
        {
            var sizeSetSize = _dbContext.SizeSetSizes.ToList();

            return Ok(sizeSetSize);
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] OrderViewModel model)
        {
            if(model == null)
                return BadRequest();

            Order newOrder = new Order()
            {
                CountryId = model.CountryId,
                CreatedDate = DateTime.Now,
                OrderNumber = model.OrderNumber,
                Termin = model.Termin
            };

            _dbContext.Orders.Add(newOrder);
            _dbContext.SaveChanges();

            for (int i = 0; i < model.Sizes.Count; i++)
            {
                OrderDetail detail = new OrderDetail()
                {
                    SizeSetId = model.SizeSetId,
                    ColorId = model.ColorId,
                    PatternId = model.PatternId,
                    SeasonId = model.SeasonId,
                    ProductId = model.ProductId,
                    OrderId = newOrder.OrderId,
                    SizeId = model.Sizes[i].SizeId,
                    Quantity = model.Quantities[i]
                };

                _dbContext.OrderDetails.Add(detail);
            }

            _dbContext.SaveChanges();

            return Ok();
        }

        //[HttpGet]
        //public IActionResult ListOrder()
        //{
        //    return Ok();
        //}

        //[HttpGet]
        //public IActionResult OrderDetail()
        //{
        //    return Ok();
        //}
    }
}
