﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebAPI.Controllers
{
    // ../api/Home
    public class HomeController : ApiController
    {
        public string[] Get()
        {
            return new string[] { "apple", "Banana", "Orange" };
        }
    }


}
