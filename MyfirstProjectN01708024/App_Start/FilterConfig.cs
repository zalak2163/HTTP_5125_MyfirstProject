﻿using System.Web;
using System.Web.Mvc;

namespace MyfirstProjectN01708024
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
