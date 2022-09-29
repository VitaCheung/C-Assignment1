﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {/// <summary>
     /// returns 10 more than the integer input {id}.
     /// </summary>
     /// <param name="id+10"></param>
     /// <returns>[id+10]</returns>
     /// <example>GET localhost/AddTen/21 --> 31</example>
     /// <example>GET localhost/AddTen/0 --> 10</example>
     /// <example>GET localhost/AddTen/-9 --> 1</example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
