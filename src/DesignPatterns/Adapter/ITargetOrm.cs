using DesignPatterns.Adapter.Models.Interfaces;

namespace DesignPatterns.Adapter
{
    public interface ITargetOrm
    {
        TDbEntity Find<TDbEntity>(int id) where TDbEntity : IDbEntity;
        void Add<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity;
        void Delete<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity;
        void Update<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity;
    }
}
