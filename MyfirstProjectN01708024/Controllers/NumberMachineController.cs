using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyfirstProjectN01708024.Controllers
{
	public class NumberMachineController : ApiController
	{

		/// <summary>
		/// Create a method which has an input {id}, and applies four mathematical operations to it.
		/// </summary>
		/// <returns>
		/// sum = id + 5;
		/// sub = id - 5;
		/// mul = id * 4;
		/// div = id / 2;
		/// </returns>
		/// <example>
		/// GET :localhost:xx/api/NumberMachine/10 ---> sum=15 ,sub=5 ,mul=40 ,div=5
		/// GET :localhost:xx/api/NumberMachine/-5 --->sum=0 ,sub=-10 ,mul=-20 ,div=-2
		/// GET :localhost:xx/api/NumberMachine/30 --->sum=35 ,sub=25 ,mul=120 ,div=15
		/// </example>
		[HttpGet]
		[Route("api/NumberMachine/{id}")]
		public string NumberMachine(int id)
		{
			int sum = id + 5;
			int sub = id - 5;
			int mul = id * 4;
			int div = id / 2;
			return $"sum={sum} ,sub={sub} ,mul={mul} ,div={div}";
		}

	}
}
