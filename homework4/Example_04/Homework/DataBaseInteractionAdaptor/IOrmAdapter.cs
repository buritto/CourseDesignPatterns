using Example_04.Homework.Models;

namespace Example_04.Homework.DataBaseInteractionAdaptor
{
    public interface IOrmAdapter // ITarget
    {
        DbUserEntity GetUserBy(int userId);
        DbUserInfoEntity GetUserInfoBy(int infoId);

        void AddNewUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity);

        void RemoveUserById(int userId);
    }
}