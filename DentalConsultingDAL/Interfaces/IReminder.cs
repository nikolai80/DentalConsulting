using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IReminder
		{
		IEnumerable<Reminder> GetReminders();
		Reminder GetReminderById(string reminderId);
		void InsertReminder(Reminder reminder);
		void EditReminder(Reminder reminder);
		void DeleteReminder(int reminderId);
		void Save();
		}
}
