using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Respository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        void Update(Service service);
    }
}
