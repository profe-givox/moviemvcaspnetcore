using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.ViewModels;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            
            var viewModel = new Address() 
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };

            ViewData["Address"]  = new Address()
            {
                Name = "Steve",
                Street = "123 Main St",
                City = "Hudson",
                State = "OH",
                PostalCode = "44236"
            };

            Title = "Este es un atributo VIew data";

            return View(viewModel);
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

                    

            return View();
        }

 
        public IActionResult OtroWelcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        
        [Route("bienvenido")]
        [Route("bienvenido/{name}")]
        public IActionResult Otro(string  name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            var o1= new {name=name , tel="445"};
            var o2= new {name=name , tel="445"};

            var arr = new object []{o1,o2};

            return Json( arr);
            
        }

        [ViewData]
        public string Title { get; set; }

    }
}