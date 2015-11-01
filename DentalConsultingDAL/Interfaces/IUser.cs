using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IUser
		{

		void Save();

		void DeleteUser(int userId);

		void EditUser(User user);

		void InsertUser(User user);

		User GetUserById(int userId);

		IEnumerable<User> GetUsers();
	}
}
