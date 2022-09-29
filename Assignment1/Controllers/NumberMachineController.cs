using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Applying four mathematical operations to the id 
        /// </summary>
        /// <param name="id*2"></param>
        /// <returns>id*10/5+1-1</returns>
        /// <example>GET localhost/NumberMachine/10 --> 20</example>
        /// <example>GET localhost/NumberMachine/-5 --> -10</example>
        /// <example>GET localhost/NumberMachine/30 --> 60</example>
        public int Get(int id)
        {
            return id * 10 / 5 + 1 - 1;

        }
            
    }
}
