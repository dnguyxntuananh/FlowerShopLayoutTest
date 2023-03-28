using Microsoft.AspNetCore.Mvc;

namespace FlowerShopLayoutTest.Controllers;
[Route("account")]
public class AccountController : Controller
{
    [Route("")]
    [Route("login")]
    public IActionResult login()
    {
        return View("Login");
    }

	[Route("register")]
	public IActionResult register()
	{
		return View("Register");
	}
}
