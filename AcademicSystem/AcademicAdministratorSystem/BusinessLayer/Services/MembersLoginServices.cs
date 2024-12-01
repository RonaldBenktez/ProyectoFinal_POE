using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace BusinessLayer.Services
{
    public class MembersLoginServices : ILoginServices
    {
        private IMembersLoginRepository _menbersRepository;

        public MembersLoginServices(IMembersLoginRepository membersRepository)
        {
            _menbersRepository = membersRepository;
        }

        public Members FindUser(Members membersInput)
        {
            return _menbersRepository.FindUser(membersInput);
        }


    }
}
