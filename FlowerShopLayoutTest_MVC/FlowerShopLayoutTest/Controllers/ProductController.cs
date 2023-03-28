using Microsoft.AspNetCore.Mvc;

namespace FlowerShopLayoutTest.Controllers;
[Route("product")]
public class ProductController : Controller
{
    [Route("")]
	[Route("flowers")]

	public IActionResult flowers()
    {
        return View("Flowers");
    }

	[Route("gifts")]

	public IActionResult gifts()
	{
		return View("Gifts");
	}

	[Route("details")]

	public IActionResult details()
	{
		return View("Details");
	}
}
