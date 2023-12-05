using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GA.ApplicationCore.Domain
{
    public class Dossier
    {
        [DataType(DataType.Date)]
        public DateTime DateDepot { get; set; }
        public string ClientFK { get; set; }
        public int AvocatFK { get; set; }
        public bool Cols { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public double Frais { get; set; }
        public virtual Avocat Avocat { get; set; }
        public virtual Client Client { get; set; }


    }
}
