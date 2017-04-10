using System;
using DesignPatterns.Adapter.Models.Interfaces;

namespace DesignPatterns.Adapter.Models
{
    public class DbUserInfoEntity : IDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
