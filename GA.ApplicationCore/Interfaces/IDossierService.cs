using GA.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GA.ApplicationCore.Interfaces
{
    public interface IDossierService: IService<Dossier>
    {
        public IList<Client> GetClients(Avocat avocat);

        public int GetNbBySpecialite(Dossier dossier);

        public void Reduction(Dossier dossier);
    }
}
