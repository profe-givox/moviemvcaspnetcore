using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.ViewModels;
using Microsoft.Docs.Samples;



[Route("api/[controller]")]
[ApiController]
public class Test2Controller : ControllerBase
{
    [HttpGet]   // GET /api/test2
    public IActionResult ListProducts()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }

    [HttpGet("{id}")]   // GET /api/test2/xyz
    public IActionResult GetProduct(string id)
    {
       return ControllerContext.MyDisplayRouteInfo(id);
    }

    [HttpGet("int/{id:int}")] // GET /api/test2/int/3
    public IActionResult GetIntProduct(int id)
    {
        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [HttpGet("int2/{id}")]  // GET /api/test2/int2/3
    public IActionResult GetInt2Product(int id)
    {

        return ControllerContext.MyDisplayRouteInfo(id);
    }

    [HttpPost]
    public IActionResult createProduct ( object objteto   ){
            return ControllerContext.MyDisplayRouteInfo();
    }

    
}