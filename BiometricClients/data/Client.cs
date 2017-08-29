namespace BiometricClients.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Devices = new HashSet<Device>();
        }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public string ClientAddress { get; set; }

        [StringLength(50)]
        public string ClientContactNo { get; set; }

        public string ClientContactPerson { get; set; }

        public bool? ClientIsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
}
