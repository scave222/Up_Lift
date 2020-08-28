using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Respository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IFrequencyRepository Frequency { get; }
        void Save();
    }
}
