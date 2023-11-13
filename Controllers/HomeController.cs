using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers;

public class HomeController : Controller
{
    [HttpGet("/method", Name = nameof(GetMethod))]
    public string GetMethod()
    {
        return "GET";
    }

    [HttpPost("/method", Name = nameof(GetMethod))]
    public string PostMethod()
    {
        return "POST";
    }
}
