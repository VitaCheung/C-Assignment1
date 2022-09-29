using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
       /// <summary>
       /// Returns the string "Hello World!"
       /// </summary>
       /// <returns>"Hello world!"</returns>
        public string Post()
            {
                return "Hello World!";
            }

        /// <summary>
        /// Returns the string "Greeting to {id} people!"
        /// </summary>
        /// <param name="Greetings"></param>
        /// <returns>"Greeting to {id} people!"</returns>
        /// <example>GET localhost/Greeting/3 -->"Greetings to 3 people!"</example> 
        /// <example>GET localhost/Greeting/6 -->"Greetings to 6 people!"</example>
        /// <example>GET localhost/Greeting/0 -->"Greetings to 0 people!"</example>
        public string Get(int id)
            {
                return "Greetings to " + id + " people!";
            }
       


    }

}

