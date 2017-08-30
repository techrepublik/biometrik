using BiometricClients.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricClients.DAL.Manager
{
    class DeviceManager
    {
        public static DataRepository<Device> _d;
        public static int Save(Device device)
        {
            var a = new Device
            {
                DeviceId = device.DeviceId,
                DeviceName = device.DeviceName,
                DeviceSerialNo = device.DeviceSerialNo,
                DeviceDatePurchase = device.DeviceDatePurchase,
                DevicePrice = device.DevicePrice,
                DeviceIsDamage = device.DeviceIsDamage,
                DeviceWarrantyDate = device.DeviceWarrantyDate,
                ClientId = device.ClientId,
                ModelId = device.ModelId,
                SupplierId = device.SupplierId
            };
            using (_d = new DataRepository<Device>())
            {
                if (device.DeviceId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.DeviceId;
        }
        public static bool Delete(Device device)
        {
            using (_d = new DataRepository<Device>())
            {
                _d.Delete(device);
                _d.SaveChanges();
            }
            return true;
        }
        public static bool Delete(int iId)
        {
            using (_d =new DataRepository<Device>())
            {
                _d.Delete(_d => _d.DeviceId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Device> GetAll()
        {
            using (_d = new DataRepository<Device>())
                _d.LazyLoadingEnabled = false;
            return _d.GetAll().OrderBy(o => o.DeviceName).ToList();
        }
        public static Device Get()
        {
            using (_d = new DataRepository<Device>())
                _d.LazyLoadingEnabled = false;
        
                return _d.FirstOrDefault(f => f.DeviceId == 1);
        } 
    }
}
