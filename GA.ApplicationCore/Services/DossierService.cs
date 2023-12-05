using GA.ApplicationCore.Domain;
using GA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA.ApplicationCore.Services
{
    public class DossierService : Service<Dossier>, IDossierService
    {
        public DossierService(IUnitOfWork utwk) : base(utwk)
        {
        }
        public int GetNbBySpecialite(Dossier dossier)
        {
            return GetMany().ToList().Where(d => d.Avocat.SpecialiteFK == dossier.Avocat.SpecialiteFK).Count();
        }

        public IList<Client> GetClients(Avocat avocat)
        {
            return GetMany(d=>d.AvocatFK==avocat.AvocatId)
                .Where(d=>DateTime.Now.Subtract(d.DateDepot).TotalDays<10)
                .Select(d=>d.Client).ToList();
        }

        public void Reduction(Dossier dossier)
        {
            var nbDossier = GetMany(d => d.AvocatFK == dossier.AvocatFK 
            && d.Cols == true 
            && d.ClientFK==dossier.ClientFK).Count();
            if (nbDossier > 3)
            {
                dossier.Frais -= dossier.Frais * 0.3;
            }
        }
    }
}
