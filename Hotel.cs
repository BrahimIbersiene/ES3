using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES3
{
    class Hotel
    {
        public ArrayList clients;

        public Hotel()
        {
            clients = new ArrayList();
        }

        public object Clients { get; internal set; }

        public void ajouterClient(Client client)
        {
            clients.Add(client);
        }

        internal void AjouterClient(Client client1)
        {
            throw new NotImplementedException();
        }
    }
}
