
using GA.ApplicationCore.Domain;
using GA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA.ApplicationCore.Services
{
    public class AvocatService : Service<Avocat>, IAvocatService
    {
        public AvocatService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
