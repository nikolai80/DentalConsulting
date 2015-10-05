using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalConsultingData
	{
	/*Класс результатов медицинских анализов*/
	public class TestResult
		{
		 [Key]
		public int TestResultID
			{
			get;
			set;
			}

		public string TestResultText
			{
			get;
			set;
			}

		public virtual User User { get; set; }
	}
	}
