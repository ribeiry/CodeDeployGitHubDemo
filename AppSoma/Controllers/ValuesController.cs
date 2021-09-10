using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppSoma.Controllers
{
    public class numbers
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        

    }
    

    [Route("api/[controller]")] 
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        // GET api/values
        [HttpGet]
        public ActionResult<int> Get([FromBody] numbers nums)
        {
            int total = 0;
            total = nums.number1 + nums.number2;
            Console.WriteLine("Retornando o valor ");
            Console.WriteLine("=======================================");
            Console.WriteLine(total);
            return total;
        }
    }
}
