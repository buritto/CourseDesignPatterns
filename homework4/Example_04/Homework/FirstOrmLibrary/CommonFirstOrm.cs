using Example_04.Homework.DataBaseInteractionAdaptor;
using Example_04.Homework.Models;

namespace Example_04.Homework.FirstOrmLibrary
{
    public class CommonFirstOrm : IOrmAdapter
    {
        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        public CommonFirstOrm(IFirstOrm<DbUserEntity> firstOrm1, IFirstOrm<DbUserInfoEntity> firstOrm2)
        {
            _firstOrm1 = firstOrm1;
            _firstOrm2 = firstOrm2;
        }


        public DbUserEntity GetUserBy(int userId)
        {
            return _firstOrm1.Read(userId);
        }

        public DbUserInfoEntity GetUserInfoBy(int infoId)
        {
            return _firstOrm2.Read(infoId);
        }

        public void AddNewUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            _firstOrm1.Add(userEntity);
            _firstOrm2.Add(userInfoEntity);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserBy(userId);
            var userInfo = GetUserInfoBy(user.InfoId);

            _firstOrm1.Delete(user);
            _firstOrm2.Delete(userInfo);
        }
    }
}