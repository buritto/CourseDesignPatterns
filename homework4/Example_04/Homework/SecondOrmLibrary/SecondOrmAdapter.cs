using System.Linq;
using Example_04.Homework.DataBaseInteractionAdaptor;
using Example_04.Homework.Models;

namespace Example_04.Homework.SecondOrmLibrary
{
    public class SecondOrmAdapter : IOrmAdapter
    {
        private ISecondOrm _secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _secondOrm = secondOrm;
        }

        public DbUserEntity GetUserBy(int userId)
        {
            return _secondOrm.Context.Users.First(user => user.Id == userId);
        }

        public DbUserInfoEntity GetUserInfoBy(int infoId)
        {
            return _secondOrm.Context.UserInfos.First(info => info.Id == infoId);
        }

        public void AddNewUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            _secondOrm.Context.Users.Add(userEntity);
            _secondOrm.Context.UserInfos.Add(userInfoEntity);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserBy(userId);
            _secondOrm.Context.Users.RemoveWhere(x => x.Id == userId);
            _secondOrm.Context.UserInfos.RemoveWhere(x => x.Id == user.InfoId);
        }
    }
}