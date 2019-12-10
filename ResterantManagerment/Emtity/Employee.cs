namespace ResterantManagerment.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Employee()
        //{
        //    OrderDetails = new HashSet<OrderDetail>();
        //}

        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        public bool? Gender { get; set; }

        [StringLength(150)]
        public string Adress { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
