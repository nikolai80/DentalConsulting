using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingData
	{

	public class GenericRepository<TEntity> where TEntity : class
		{
		internal DentalConsultingContext context;
	}
}
