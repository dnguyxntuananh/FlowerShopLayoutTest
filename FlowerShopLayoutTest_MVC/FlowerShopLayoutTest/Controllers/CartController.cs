﻿using Microsoft.AspNetCore.Mvc;

namespace FlowerShopLayoutTest.Controllers;
[Route("cart")]
public class CartController : Controller
{
    [Route("")]
	[Route("index")]

	public IActionResult Index()
    {
        return View();
    }
}
