using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricClients.DAL.obj
{
    public class ClientData
    {
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson { get; set; }
        public bool? ClientIsActive { get; set; }
        public bool? DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSerialNo { get; set; }
        public DateTime? DatePurchase { get; set; }
        public double? DevicePrice { get; set; }
        public DateTime? DateWarranty { get; set; }
        public string ModelName { get; set; }
        public string SupplierName { get; set; }
    }
}
