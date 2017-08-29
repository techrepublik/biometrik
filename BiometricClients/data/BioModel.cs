namespace BiometricClients.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BioModel : DbContext
    {
        public BioModel()
            : base("name=BioModel")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Devices)
                .WithOptional(e => e.Client)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Device>()
                .Property(e => e.DeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Device>()
                .Property(e => e.DeviceSerialNo)
                .IsUnicode(false);

            modelBuilder.Entity<Device>()
                .HasMany(e => e.Softwares)
                .WithOptional(e => e.Device)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Model>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<Software>()
                .Property(e => e.SoftwarePerson)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierCode)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierContactPerson)
                .IsUnicode(false);
        }
    }
}
