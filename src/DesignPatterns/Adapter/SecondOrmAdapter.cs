using System.Linq;
using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.SecondOrmLibrary;

namespace DesignPatterns.Adapter
{
    public class SecondOrmAdapter : ITargetOrm
    {
        private readonly ISecondOrm _secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _secondOrm = secondOrm;
        }

        public void AddUser(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            user.UserInfoId = userInfo.Id;
            _secondOrm.Context.UserInfos.Add(userInfo);
            _secondOrm.Context.Users.Add(user);
        }

        public void UpdateUserInfo(int userId, DbUserInfoEntity userInfo)
        {
            var user = _secondOrm.Context.Users.First(x => x.Id == userId);
            var dbUserInfo = _secondOrm.Context.UserInfos.First(x => x.Id == user.Id);
            dbUserInfo.Birthday = userInfo.Birthday;
            dbUserInfo.Name = userInfo.Name;
        }

        public void DeleteUser(int userId)
        {
            var user = _secondOrm.Context.Users.First(x => x.Id == userId);
            var userInfo = _secondOrm.Context.UserInfos.First(x => x.Id == user.UserInfoId);
            _secondOrm.Context.UserInfos.Remove(userInfo);
            _secondOrm.Context.Users.Remove(user);
        }

        public void UpdateUser(int userId, DbUserEntity user)
        {
            var dbUser = _secondOrm.Context.Users.First(x => x.Id == userId);
            dbUser.Login = user.Login;
            dbUser.PasswordHash = user.PasswordHash;
            dbUser.UserInfoId = user.UserInfoId;
        }

        public void ChangePassword(int userId, string newPasswordHash)
        {
            var user = _secondOrm.Context.Users.First(x => x.Id == userId);
            user.PasswordHash = newPasswordHash;
        }
    }
}