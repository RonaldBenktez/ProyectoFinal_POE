using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface IMembersRepository
    {
        DataTable GetAllMembers();
        DataTable GEtEstudentsOrTeachers(int rolId);

        DataTable SearchMember(string searchTerm);

        void AddMembers(Members memberAddData);

        DataTable GetRoles();

        void EditMember(Members memberEdited);

        void DeleteMember(int MemberId);

    }


}
