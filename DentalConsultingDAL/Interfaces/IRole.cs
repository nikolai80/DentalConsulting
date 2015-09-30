using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IRole
		{
		IEnumerable<Role> GetRoles();
		Role GetRoleById(string roleId);
		void InsertRole(Role role);
		void EditRole(Role role);
		void DeleteRole(int roleId);
		void Save();
		}
	}
