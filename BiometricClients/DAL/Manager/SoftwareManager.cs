using BiometricClients.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricClients.DAL.Manager
{
    class SoftwareManager
    {
        public static DataRepository<Software> _d;

        public static int Save(Software software)
        {
            var a = new Software
            {
                SoftwareId = software.SoftwareId,
                SoftwareDate = software.SoftwareDate,
                SoftwarePerson = software.SoftwarePerson
            };
            {
                using (_d = new DataRepository<Software>())
                    if (software.SoftwareId > 0)
                        _d.Update(a);
                    else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SoftwareId;
        }
        public static bool Delete(Software software)
        {
            using (_d = new DataRepository<Software>())
            {

                _d.Delete(software);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Software>())
            {

                _d.Delete(d => d.DeviceId == iId);
                _d.SaveChanges();

            }
            return true;
        }
        public static List<Software> GetAll()
        {
            using (_d = new DataRepository<Software>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SoftwarePerson).ToList();
            }
        }
    }
}

