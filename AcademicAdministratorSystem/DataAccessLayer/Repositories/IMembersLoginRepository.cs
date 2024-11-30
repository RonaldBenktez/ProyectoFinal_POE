using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface IMembersLoginRepository
    {
        Members FindUser(Members mebersInput);
    }
}