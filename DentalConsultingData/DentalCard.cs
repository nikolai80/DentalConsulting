﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	//Стоматологическая карта
	public class DentalCard
		{

		public int DentalCardID
			{
			get;
			set;
			}

		public string DentalCardContent
			{
			get;
			set;
			}

		public virtual User User { get; set; }
	}
	}
