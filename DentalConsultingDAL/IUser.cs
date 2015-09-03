using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalConsultingDAL
	{

	public interface IUser
		{

		void Save();

		void DeleteUser(int userId);

		void EditUser(User user);

		void InsertUser(User user);

		User GetUserById(string userId);

		IEnumerale<User> GetUsers();
	}
}
