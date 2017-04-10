﻿using System.Collections.Generic;
using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter.SecondOrmLibrary
{
    public interface ISecondOrm
    {
        ISecondOrmContext Context { get; }
    }

    public interface ISecondOrmContext
    {
        HashSet<DbUserEntity> Users { get; }
        HashSet<DbUserInfoEntity> UserInfos { get; }
    }
}