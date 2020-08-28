﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Respository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Respository
{
    public class FrequencyRepository : Repository<Frequency>, IFrequencyRepository
    {
        private readonly ApplicationDbContext _db;
        public FrequencyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetFrequencyListForDropDown()
        {
            return _db.Frequency.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

        }

        public void Update(Frequency frequency)
        {
            var objFromDb = _db.Category.FirstOrDefault(s => s.Id == frequency.Id);
            objFromDb.Name = frequency.Name;
            objFromDb.DisplayOrder = frequency.FrequencyCount;
            _db.SaveChanges();
        }
    }
}
