using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface ITestResult
		{
		void Save();

		void DeleteTestResult(int userId);

		void EditTestResult(TestResult user);

		void InsertTestResult(TestResult user);

		TestResult GetTestResultById(string userId);

		IEnumerable<TestResult> GetTestResult();
		}
}
