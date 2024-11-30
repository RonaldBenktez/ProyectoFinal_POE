
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class MembersServices : IMembersServices
    {
        private IMembersRepository _adminRepository;

        public MembersServices(IMembersRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public DataTable GetAllMembers()
        {
            return _adminRepository.GetAllMembers();
        }

        public DataTable GetEstudentsOrTeachers(int rolId)
        {
            return _adminRepository.GEtEstudentsOrTeachers(rolId);
        }

        public DataTable SearchMember(string searchTerm)
        {
            return _adminRepository.SearchMember(searchTerm);
        }

        public void AddMebers(Members addMemberData)
        {
            _adminRepository.AddMembers(addMemberData);
        }

        public DataTable GetRoles()
        {
            return _adminRepository.GetRoles();
        }

        public void EditMember(Members memberEdited)
        {
            _adminRepository.EditMember(memberEdited);
        }

        public void DeleteMember(int MemberId)
        {
            _adminRepository.DeleteMember(MemberId);
        }
    }
}
