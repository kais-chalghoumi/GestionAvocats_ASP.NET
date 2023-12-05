using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GA.ApplicationCore.Domain
{
    public class Avocat
    {
        public int AvocatId { get; set; }
        public int? SpecialiteFK { get; set; }
        [Required(ErrorMessage ="Nom obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Prenom obligatoire")]
        public string Prenom { get; set; }

        [NotMapped]
        public string NomPrenom { get { return Nom + " " + Prenom; } }
        
        [DataType(DataType.Date)]
        public DateTime DateEmbauche { get; set; }
        public virtual IList<Dossier> Dossiers { get; set; }
        public virtual Specialite Specialite { get; set; }
    }
}
