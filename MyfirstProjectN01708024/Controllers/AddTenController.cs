using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyfirstProjectN01708024.Controllers
{
    public class AddTenController : ApiController
    {
		/// <summary>
		/// Returns 10 more than the integer input {id}. 
		/// </summary>
		/// <returns>
		/// {id} + 10
		/// </returns>
		/// <example>
		/// GET :localhost:xx/api/AddTen/21 ---> 31
		/// GET :localhost:xx/api/AddTen/0 ---> 10
		///GET :localhost:xx/api/AddTen/-9 ---> 1
		/// </example>
		public int Get(int id) 
        {
            return id + 10;
        }
    }
}
