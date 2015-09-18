using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IAdvice
		{
		IEnumerable<Advice> GetAllAdvice();
		Advice GetAdviceById(string adviceId);
		void InsertAdvice(Advice advice);
		void EditAdvice(Advice advice);
		void DeleteAdvice(int adviceId);
		void Save();
		}
}
