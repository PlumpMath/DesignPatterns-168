using System;
using DesignPatterns.Adapter.FirstOrmLibrary;
using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.Models.Interfaces;

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

        public TDbEntity Find<TDbEntity>(int id) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                var result = _firstUserOrm.Read(id);
                var casted = Convert.ChangeType(result, type);
                return (TDbEntity)casted;
            }
            if (type == typeof(DbUserInfoEntity))
            {
                var result = _firstUserInfoOrm.Read(id);
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
                _firstUserOrm.Update(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                _firstUserInfoOrm.Update(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }

        public void Delete<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                _firstUserOrm.Delete(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                _firstUserInfoOrm.Delete(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }

        public void Update<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity
        {
            var type = typeof(TDbEntity);
            if (type == typeof(DbUserEntity))
            {
                _firstUserOrm.Update(entity as DbUserEntity);
            }
            if (type == typeof(DbUserInfoEntity))
            {
                _firstUserInfoOrm.Update(entity as DbUserInfoEntity);
            }
            throw new NotSupportedException();
        }
    }
}