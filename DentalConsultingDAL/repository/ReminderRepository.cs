using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class ReminderRepository : IReminder, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<Reminder> GetReminders()
			{
			throw new NotImplementedException();
			}

		public Reminder GetReminderById(string reminderId)
			{
			throw new NotImplementedException();
			}

		public void InsertReminder(Reminder reminder)
			{
			throw new NotImplementedException();
			}

		public void EditReminder(Reminder reminder)
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
