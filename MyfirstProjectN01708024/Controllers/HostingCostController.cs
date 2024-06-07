using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace MyfirstProjectN01708024.Controllers
{
    public class HostingCostController : ApiController
    {
		/// <summary>
		/// charging our client $5.50 / FN (fortnight = 14 days) for web hosting and maintenanceplus an additional 13% HST.
		/// The input { id }represents the number of days which has elapsedsince the beginning of the hosting.
		/// Output 3 strings which describe the total hosting cost.
		/// </summary>
		/// <returns>
		/// fortnights = (id / 14) + 1;
		///chargetoclient = fortnights * 5.50;
		///hstcost = chargetoclient * 0.13;
		///total = chargetoclient + hstcost;
		/// </returns>
		/// <example>
		/// GET :localhost:xx/api/HostingCost/0 --->1 fortnights at $5.50/FN = $5.5 CAD HST 13% = $0.715 CAD Total = $6.22 CAD
		/// GET :localhost:xx/api/HostingCost/14 --->2 fortnights at $5.50/FN = $11 CAD HST 13% = $1.43 CAD Total = $12.43 CAD
		/// GET :localhost:xx/api/HostingCost/15-->2 fortnights at $5.50/FN = $11 CAD HST 13% = $1.43 CAD Total = $12.43 CAD
		/// GET :localhost:xx/api/HostingCost/21-->2 fortnights at $5.50/FN = $11 CAD HST 13% = $1.43 CAD Total = $12.43 CAD
		/// GET :localhost:xx/api/HostingCost/28-->3 fortnights at $5.50/FN = $16.5 CAD HST 13% = $2.145 CAD Total = $18.65 CAD
		/// </example>

		/*i got this output  (1 fortnights at $5.50/FN = $5.5 CAD HST 13% = $0.715 CAD Total = $6.22 CAD) because i dont know logic for adding two decimal poin*/

		public string Get(int id)
		{
			int fortnights = (id / 14) + 1;
			double chargetoclient = fortnights * 5.50;
			double hstcost = chargetoclient * 0.13;
			double total = chargetoclient + hstcost;

			string charge = $"{fortnights} fortnights at $5.50/FN = ${chargetoclient} CAD";
			string hst = $"HST 13% = ${hstcost} CAD";
			string totalcharge = $"Total = ${total:F2} CAD";

			return $"{charge}\n{hst}\n{totalcharge}";

		}
	}
}


