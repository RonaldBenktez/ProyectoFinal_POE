using CommonLayer.Entities;
using System.Data;

namespace BusinessLayer.Services
{
    public interface IMembersServices
    {
        DataTable GetAllMembers();

        DataTable GetEstudentsOrTeachers(int rolId);

        DataTable SearchMember(string searchTerm);

        void AddMebers(Members addMemberData);

        DataTable GetRoles();

        void EditMember(Members membersEdited);
        void DeleteMember(int MemberId);
    }
}