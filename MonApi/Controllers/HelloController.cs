using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonApi.Services;



namespace MonApi.Controllers
{

    [ApiController]
    [Route("api")]
    public class HelloController : ControllerBase
    {

        private readonly MathService _mathService;

   
        public HelloController(MathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet("hello")]  // 
        public IActionResult Hello()
        {
           
            int resultat = _mathService.Addition(40, 2);

    
            return Ok(new { message = $"Bonjour {resultat}" });
        }
    }
}