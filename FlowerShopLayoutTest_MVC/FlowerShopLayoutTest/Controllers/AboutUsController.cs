using Microsoft.AspNetCore.Mvc;

namespace FlowerShopLayoutTest.Controllers;
[Route("aboutus")]
public class AboutUsController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
