
using GA.ApplicationCore.Domain;
using GA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA.ApplicationCore.Services
{
    public class SpecialiteService : Service<Specialite>, ISpecialiteService
    {
        public SpecialiteService(IUnitOfWork utwk) : base(utwk)
        {
        }

        public Specialite GetByMaxAvocats()
        {
            return GetMany().OrderByDescending(s => s.Avocats.Count()).FirstOrDefault();
        }

        
    }
}
