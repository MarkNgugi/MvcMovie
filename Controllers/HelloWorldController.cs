using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{   
    //localhost/{port}/helloworld
    public string Index()
    {
        return "This is the index page";
    }

    //localhost/{port}/helloworld/welcome
    public string Welcome()
    {
        return "Welcome to the welcome page";
    }

    public string mark()
    {
        return "mark is a pro in .net";
    }

}

