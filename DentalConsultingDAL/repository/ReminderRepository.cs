using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingDAL
	{

	public class ReminderRepository : IReminder, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<DentalConsultingData.Reminder> GetReminders()
			{
			throw new NotImplementedException();
			}

		public DentalConsultingData.Reminder GetReminderById(string reminderId)
			{
			throw new NotImplementedException();
			}

		public void InsertReminder(DentalConsultingData.Reminder reminder)
			{
			throw new NotImplementedException();
			}

		public void EditReminder(DentalConsultingData.Reminder reminder)
			{
			throw new NotImplementedException();
			}

		public void DeleteReminder(int reminderId)
			{
			throw new NotImplementedException();
			}

		public void Save()
			{
			throw new NotImplementedException();
			}
		bool disposed = false;
		protected virtual void Dispose(bool disposing)
			{
			if(!this.disposed)
				{
				if(disposing)
					{
					context.Dispose();
					}
				}
			this.disposed = true;
			}
		public void Dispose()
			{
			Dispose(true);
			GC.SuppressFinalize(this);
			}
		}
}
