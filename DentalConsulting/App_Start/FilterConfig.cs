using System.Web;
using System.Web.Mvc;

namespace DentalConsulting
	{
	public class FilterConfig
		{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
			{
			filters.Add(new HandleErrorAttribute());
			}
		}
	}
