using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
     /// Returns the square of the integer input {id}.
     /// </summary>
     /// <param name="id*id"></param>
     /// <returns>[id*id]</returns>
     /// <example> GET localhost/Square/2--> 4</example>
     /// <example> GET localhost/Square/-2--> 4</example>
     /// <example> GET localhost/Square/10--> 100</example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
