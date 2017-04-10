using System;
using System.Linq;
using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.Models.Interfaces;
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

        public TDbEntity Find<TDbEntity>(int id) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                var result = _secondOrm.Context.Users.FirstOrDefault(x => x.Id == id);
                var casted = Convert.ChangeType(result, type);
                return (TDbEntity)casted;
            }
            if (type == typeof(DbUserInfoEntity))
            {
                var result = _secondOrm.Context.UserInfos.FirstOrDefault(x => x.Id == id);
                var casted = Convert.ChangeType(result, type);
                return (TDbEntity)casted;
            }
            throw new NotSupportedException();
        }

        public void Add<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                _secondOrm.Context.Users.Add(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                _secondOrm.Context.UserInfos.Add(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }

        public void Delete<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                _secondOrm.Context.Users.Remove(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                _secondOrm.Context.UserInfos.Remove(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }

        public void Update<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                var existed = _secondOrm.Context.Users.First(x => x.Id == entity.Id);
                _secondOrm.Context.Users.Remove(existed);
                _secondOrm.Context.Users.Add(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                var existed = _secondOrm.Context.UserInfos.First(x => x.Id == entity.Id);
                _secondOrm.Context.UserInfos.Remove(existed);
                _secondOrm.Context.UserInfos.Add(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }
    }
}