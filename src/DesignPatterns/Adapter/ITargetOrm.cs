using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter
{
    public interface ITargetOrm
    {
        void AddUser(DbUserEntity user, DbUserInfoEntity userInfo);
        void UpdateUserInfo(int userId, DbUserInfoEntity userInfo);
        void DeleteUser(int userId);
        void UpdateUser(int userId, DbUserEntity user);
        void ChangePassword(int userId, string newPasswordHash);
    }
}
