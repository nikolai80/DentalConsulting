using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class ChatRepository : IChat, IDisposable
		{
		private DentalConsultingContext context;
		public IEnumerable<Chat> GetChats()
			{
			throw new NotImplementedException();
			}

		public Chat GetChatById(string chatId)
			{
			throw new NotImplementedException();
			}

		public void InsertChat(Chat chat)
			{
			throw new NotImplementedException();
			}

		public void EditChat(Chat chat)
			{
			throw new NotImplementedException();
			}

		public void DeleteChat(int chatId)
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
