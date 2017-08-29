namespace BiometricClients.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            Softwares = new HashSet<Software>();
        }

        public int DeviceId { get; set; }

        [StringLength(50)]
        public string DeviceName { get; set; }

        [StringLength(50)]
        public string DeviceSerialNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeviceDatePurchase { get; set; }

        public double? DevicePrice { get; set; }

        public bool? DeviceIsDamage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeviceWarrantyDate { get; set; }

        public int? ModelId { get; set; }

        public int? ClientId { get; set; }

        public int? SupplierId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Model Model { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Software> Softwares { get; set; }
    }
}
