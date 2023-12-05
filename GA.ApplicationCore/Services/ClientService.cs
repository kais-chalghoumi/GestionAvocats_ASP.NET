
using GA.ApplicationCore.Domain;
using GA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA.ApplicationCore.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
