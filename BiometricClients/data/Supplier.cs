namespace BiometricClients.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Devices = new HashSet<Device>();
        }

        public int SupplierId { get; set; }

        [StringLength(50)]
        public string SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public string SupplierAddress { get; set; }

        [StringLength(50)]
        public string SupplierContactNo { get; set; }

        public string SupplierContactPerson { get; set; }

        public bool? SupplierIsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
}
