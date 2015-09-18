using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public interface IRole
		{
		IEnumerable<s> GetRoles();
		s GetRoleById(string roleId);
		void InsertRole(s role);
		void EditRole(s role);
		void DeleteRole(int roleId);
		void Save();
		}
	}
