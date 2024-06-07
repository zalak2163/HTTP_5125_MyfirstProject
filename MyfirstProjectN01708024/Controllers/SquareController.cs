using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyfirstProjectN01708024.Controllers
{
    public class SquareController : ApiController
    {
		/// <summary>
		/// Returns the square of the integer input 
		/// </summary>
		/// <returns>
		/// {id} * {id}
		/// </returns>
		/// <example>
		/// GET :localhost:xx/api/Square/10 ---> 100
		/// GET :localhost:xx/api/Square/2 ---> 4
		///GET :localhost:xx/api/Square/-2 ---> 4
		/// </example>
		public int Get(int id)
		{
			return id * id;
		}
	}
}
