using System.Linq;
using Example_04.Homework.DataBaseInteractionAdaptor;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;

namespace Example_04.Homework.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;


        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = _ormAdapter.GetUserBy(userId);
            var userInfo = _ormAdapter.GetUserInfoBy(user.InfoId);

            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.AddNewUser(user, userInfo);
        }

        public void Remove(int userId)
        {
            _ormAdapter.RemoveUserById(userId);
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }
    }
}