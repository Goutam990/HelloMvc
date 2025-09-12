using Microsoft.AspNetCore.Mvc; // To use the Controller class in code. ye likhna padhta h.
using HelloMvc.Models;

namespace HelloMvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details() // ye action h layout ke andr ka action isi ko dhudhega.

        {
            var product = new Product
            {
                Id = 1,
                Name = "Boat Ear Buds",
                Price = 1200
            };

            return View(product); // Pass the model to the view.
        }
    }
}
