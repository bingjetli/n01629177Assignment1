using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01629177Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET /api/AddTen/{id}
        /// <summary>
        /// Takes an integer and returns the integer with 10 added to it.
        /// </summary>
        /// <example>GET /api/AddTen/{id}</example>
        /// <param name="id"></param>
        /// <returns>id + 10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
