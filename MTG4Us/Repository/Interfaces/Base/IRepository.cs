﻿using Dapper;
using Domain;
using Domain.Base;
using System.Collections.Generic;

namespace Repository.Interfaces.Base
{
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        bool Remove(T obj);
        List<T> GetAll();
        T Update(T obj);
        T GetById(int id);
        List<T> ExecuteQuery(string query, DynamicParameters parameters);
    }
}
