using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01629177Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Takes an integer and performs 4 arithmetic operations to it.
        /// </summary>
        /// <example>GET /api/NumberMachine/{id}</example>
        /// <param name="id"></param>
        /// <returns>(id * id) / (id + id) - id</returns>
        public int Get(int id)
        {
            return (id * id) / (id + id) - id;
        }
    }
}
