using Microsoft.AspNetCore.Mvc;

namespace FlowerShopLayoutTest.Controllers;
[Route("contact")]
public class ContactController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
