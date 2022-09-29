using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        ///  Hosting cost is $5.50/FN with an 13%HST
        /// </summary>
        /// <param name="total hosting cost"></param>
        /// <returns>Returns the number of days {id} to the total hosting cost</returns>
        /// <example>Get api HostingCost/0 -> “1 fortnights at $5.50/FN = $5.50 CAD” “HST 13% = $0.72 CAD”“Total = $6.22 CAD” </example>
        /// <example>Get api HostingCost/14 -> “2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD” </example>
        public IEnumerable<string> Get(int id)
        {
            decimal fortnight = (decimal)id / 14;
            fortnight = Math.Floor(fortnight)+1;

            decimal price = 5.50M;
            decimal cost = Math.Round(price * fortnight,2);
            decimal taxTotal = Math.Round(cost * 0.13M,2);
            decimal Total = cost + taxTotal;

           
            return new string[] {fortnight + " fortnights at $5.50/FN = $" + cost + " CAD",
            "HST 13 % = $" + taxTotal + " CAD",
            "Total = $" + Total + " CAD"};

        }
    }
}
