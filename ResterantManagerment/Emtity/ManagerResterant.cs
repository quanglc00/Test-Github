namespace ResterantManagerment.Emtity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManagerResterant : DbContext
    {
        public ManagerResterant()
            : base("name=ManagerResterant")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<KindOfDish> KindOfDishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Dish>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);


            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
