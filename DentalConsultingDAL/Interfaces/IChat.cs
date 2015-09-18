using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IChat
		{
		IEnumerable<Chat> GetChats();
		Chat GetChatById(string chatId);
		void InsertChat(Chat chat);
		void EditChat(Chat chat);
		void DeleteChat(int chatId);
		void Save();
		}
}
