﻿using LexShop.Core.Models;
using System.Linq;

namespace LexShop.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void commit();
        void Delete(string Id);
        T Find(string Id);
        void insert(T t);
        void Update(T t);
    }
}