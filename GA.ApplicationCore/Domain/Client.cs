using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GA.ApplicationCore.Domain
{
    public class Client
    {
        [Key]
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [NotMapped]
        public string NomPrenom { get { return Nom + " " + Prenom; } }
        public virtual IList<Dossier> Dossiers { get; set; }

    }
}
