using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class DataContext : DbContext
		{

		public DataContext():base("DentalConsulting")
			{
			}

		public DbSet<Article> Articles { get; set;}
	}
}
