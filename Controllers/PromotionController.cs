using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : Controller
    {
        [HttpGet]
        public IActionResult Get(double total_price)
        {
            var promotion = new Usecases.Promotion();
            promotion.TotalPrice = total_price;

            var model = new PromotionModel();
            model.Discount = promotion.GetDiscount();

            return Ok(model);
        }
    }
}
