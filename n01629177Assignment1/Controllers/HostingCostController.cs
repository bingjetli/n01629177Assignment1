using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01629177Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Takes the number of days that have elapsed since the beginning of your hosting period.
        /// </summary>
        /// <example>GET /api/HostingCost/{id}</example>
        /// <param name="id"></param>
        /// <returns>
        ///     "{fortnights} fort night(s) at $5.50/FN = {subtotal}"
        ///     "HST 13% = {hst} CAD"
        ///     "Total = {total} CAD"
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            double fortnights = (id / 14) + 1;
            double subtotal = fortnights * 5.5;
            double hst = subtotal * 0.13;
            return new string[]
            {
                (int) fortnights + " fort night(s) at $5.50/FN = " + subtotal.ToString("c2") + " CAD",
                "HST 13% = " + hst.ToString("c2") + " CAD",
                "Total = " + (subtotal + hst).ToString("c2") + " CAD"
            };
        }
    }
}
