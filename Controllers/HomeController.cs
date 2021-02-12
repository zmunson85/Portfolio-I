using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers     
{
    public class HomeController : Controller   //remember inheritance??
    {
        //routes come from the controller requests
        [HttpGet]       //http requestrequest
        [Route("")]     //associated route string exclude the leading /, like django w used / for root.
        public string Index()
        {
            return "This is my Index";
        }

        [HttpGet]
        [Route("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet]
        [Route("contact")]
        public string Contact()
        {
            return "This is my Contact";
        }
    }
}