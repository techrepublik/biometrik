namespace BiometricClients.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Software
    {
        public int SoftwareId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SoftwareDate { get; set; }

        [StringLength(50)]
        public string SoftwarePerson { get; set; }

        public int? DeviceId { get; set; }

        public virtual Device Device { get; set; }
    }
}
