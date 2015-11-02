using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IDentalCard
		{
		DentalCard GetDentalCardById(int dentalCardId);
		void InsertDentalCard(DentalCard dentalCard);
		void EditDentalCard(DentalCard dentalCard);
		void DeleteDentalCard(int dentalCardId);
		void Save();
		}
}
