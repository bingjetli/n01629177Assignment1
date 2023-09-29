using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01629177Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Takes an integer id, and returns the value squared.
        /// </summary>
        /// <example>GET /api/Square/{id}</example>
        /// <param name="id"></param>
        /// <returns>id^2</returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
