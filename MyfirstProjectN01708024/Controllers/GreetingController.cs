using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyfirstProjectN01708024.Controllers
{
    public class GreetingController : ApiController
    {
		/// <summary>
		/// (Post method) Returns the string “Hello World!”.
		/// </summary>
		/// <returns>
		/// "Hello World!"
		/// </returns>
		/// <example>
		/// curl -d "" http://localhost:xx/api/Greeting ---> "Hello World!"
		/// </example>
		public string Post()
		{
			string response = "Hello World!";
			return response;
		}
		/// <summary>
		///Returns the string “Greetings to {id} people!” where id is an integer value.
		/// </summary>
		/// <returns>
		/// "Greetings to " + id + " People!"
		/// </returns>
		/// <example>
		/// GET :localhost:xx/api/Greeting/3 ---> Greetings to 3 People!
		/// GET :localhost:xx/api/Greeting/6 ---> Greetings to 6 People!
		/// GET :localhost:xx/api/Greeting/0 ---> Greetings to 0 People!
		/// </example>
		public string Get(int id)
		{
			string Message = "Greetings to " + id + " People!";
			return Message;
		}
	}
}
