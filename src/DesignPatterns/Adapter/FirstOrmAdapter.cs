using DesignPatterns.Adapter.FirstOrmLibrary;
using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter
{
    public class FirstOrmAdapter : ITargetOrm
    {
        private readonly IFirstOrm<DbUserEntity> _firstUserOrm;
        private readonly IFirstOrm<DbUserInfoEntity> _firstUserInfoOrm;

        public FirstOrmAdapter(
            IFirstOrm<DbUserEntity> firstUserOrm,
            IFirstOrm<DbUserInfoEntity> firstUserInfoOrm)
        {
            _firstUserOrm = firstUserOrm;
            _firstUserInfoOrm = firstUserInfoOrm;
        }

        public void AddUser(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            user.UserInfoId = userInfo.Id;
            _firstUserOrm.Update(user);
            _firstUserInfoOrm.Update(userInfo);
        }

        public void UpdateUserInfo(int userId, DbUserInfoEntity userInfo)
        {
            var user = _firstUserOrm.Read(userId);
            var dbUserInfo = _firstUserInfoOrm.Read(user.UserInfoId);
            dbUserInfo.Birthday = userInfo.Birthday;
            dbUserInfo.Name = userInfo.Name;
        }

        public void DeleteUser(int userId)
        {
            var user = _firstUserOrm.Read(userId);
            var userInfo = _firstUserInfoOrm.Read(user.UserInfoId);
            _firstUserInfoOrm.Delete(userInfo);
            _firstUserOrm.Delete(user);
        }

        public void UpdateUser(int userId, DbUserEntity user)
        {
            var userFromDb = _firstUserOrm.Read(userId);
            userFromDb.UserInfoId = user.UserInfoId;
            userFromDb.Login = user.Login;
            userFromDb.PasswordHash = user.PasswordHash;
        }

        public void ChangePassword(int userId, string newPasswordHash)
        {
            var user = _firstUserOrm.Read(userId);
            user.PasswordHash = newPasswordHash;
        }
    }
}