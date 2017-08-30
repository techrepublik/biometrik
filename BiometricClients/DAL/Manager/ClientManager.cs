using BiometricClients.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricClients.DAL.Manager
{
    /// <summary>
    /// ClientManager - used to managed client
    /// 
    /// </summary>
    class ClientManager
    {
        public static DataRepository<Client> _d;
        public static int Save(Client client)
        {
            var a = new Client
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                ClientAddress = client.ClientAddress,
                ClientContactNo = client.ClientContactNo,
                ClientContactPerson = client.ClientContactPerson,
                ClientIsActive = client.ClientIsActive
            };
            using (_d = new DataRepository<Client>())
            {
                if (client.ClientId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();

            }
            return a.ClientId;
        }
        public static bool Delete(Client client)
        {
            using (_d = new DataRepository<Client>())
            {
                _d.Delete(client);
                _d.SaveChanges();
            }
            return true;
        }
        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Client>())
            {
                _d.Delete(d => d.ClientId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Client> GetAll()
        {
            using (_d = new DataRepository<Client>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
        public static List<Client> GetAll(bool bActive)
        {
            using (_d = new DataRepository<Client>())
            {
                _d.LazyLoadingEnabled = false;
                return
                    _d.Find(f => f.ClientIsActive == bActive)
                    .OrderBy(o => o.ClientName).ThenBy(o => o.ClientContactPerson)
                    .ToList();
            }
        }
    }
}

