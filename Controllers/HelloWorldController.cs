using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{   
    //localhost/{port}/helloworld
    public IActionResult Index()
    {
        return View();
    }

    //localhost/{port}/helloworld/welcome
    public IActionResult Welcome()
    {
        return View();
    }

    public string mark()
    {
        return "mark is a pro in .net";
    }

}

