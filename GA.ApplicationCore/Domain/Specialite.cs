using System;
using System.Collections.Generic;
using System.Text;

namespace GA.ApplicationCore.Domain
{
    public class Specialite
    {
        public int Id { get; set; }
        public string NomSpecialite { get; set; }
        public string Description { get; set; }
        public virtual IList<Avocat> Avocats { get; set; }
    }
}
