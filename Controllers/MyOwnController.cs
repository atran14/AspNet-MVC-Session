using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC_Session.Controllers
{
    public class MyOwnController : Controller
    {
        [Route("Test/VeryNewIndex")]
        public string NewIndex()
        {
            return "Hello World!";
        }
    }
}