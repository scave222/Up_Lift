﻿using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess.Data.Respository.IRepository;

namespace Uplift.DataAccess.Data.Respository
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork( ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}