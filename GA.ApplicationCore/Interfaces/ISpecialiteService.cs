using GA.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.ApplicationCore.Interfaces
{
    public interface ISpecialiteService: IService<Specialite>
    {
        public Specialite GetByMaxAvocats();
    }
}
