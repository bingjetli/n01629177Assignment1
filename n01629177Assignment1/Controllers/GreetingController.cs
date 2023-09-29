using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01629177Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string 'Hello World!'
        /// </summary><example>POST /api/Greeting</example>
        /// <returns>'Hello World!'</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Takes an integer and returns a greeting addressing that many people.
        /// </summary><example>GET /api/Greeting/{id}</example>
        /// <param name="id"></param>
        /// <returns>"Greetings to " + id + " people!"</returns>
        public string Get(int id) {
            return "Greetings to " + id + " people!";
        }
    }
}
