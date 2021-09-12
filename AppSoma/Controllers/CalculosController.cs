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
    public class CalculosController : ControllerBase
    {
        
        // POST api/values
        [HttpPost]
        [Route("soma")]
        public ActionResult<Double> Soma([FromBody] numbers nums)
        {
            Double total = 0;
            total = nums.number1 + nums.number2;
            Console.WriteLine("Retornando o valor ");
            Console.WriteLine("=======================================");
            Console.WriteLine(total);
            return total;
        }


        // POST api/values
        [HttpPost]
        [Route("subtrair")]
        public ActionResult<Double> Subtrair([FromBody] numbers nums)
        {
            Double total = 0;
            total = nums.number1 - nums.number2;
            Console.WriteLine("Retornando o valor ");
            Console.WriteLine("=======================================");
            Console.WriteLine(total);
            return total;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Double> Multiplicar([FromBody] numbers nums)
        {
            Double total = 0;
            total = nums.number1 * nums.number2;
            Console.WriteLine("Retornando o valor ");
            Console.WriteLine("=======================================");
            Console.WriteLine(total);
            return total;
        }


        // POST api/values
        [HttpPost]
        public ActionResult<Double> Dividir([FromBody] numbers nums)
        {
            Double total = 0;

            if (nums.number1.Equals(0) || nums.Equals(0))
            {
                total = 0;
            }                
            else
            {
                total = nums.number1 / nums.number2;
            }
            Console.WriteLine("Retornando o valor ");
            Console.WriteLine("=======================================");
            Console.WriteLine(total);
            return total;
        }



    }
}
