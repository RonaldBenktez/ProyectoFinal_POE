using CommonLayer.Entities;

namespace BusinessLayer.Services
{
    public interface ILoginServices
    {
        Members FindUser(Members membersInput);
    }
}