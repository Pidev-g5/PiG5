﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IDataBaseFactory Factory;
        public UnitOfWork(IDataBaseFactory Factory)
        {
            this.Factory = Factory;
        }
        public void Commit()
        {
            Factory.DataContext.SaveChanges();
        }

        public void Dispose()
        {
            Factory.Dispose();
        }

        public IRepositoryBase<T> GetRepositoryBase<T>() where T : class
        {
            return new RepositoryBase<T>(Factory);
        }
    }
}
