namespace ResterantManagerment.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dish")]
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            //OrderDetails = new HashSet<OrderDetail>();
        }

        public int DishId { get; set; }

        [StringLength(150)]
        public string DishName { get; set; }

        public decimal? Price { get; set; }

        public int? KindOfDishId { get; set; }

        //[StringLength(255)]
        //public string Image { get; set; }

        public virtual KindOfDish KindOfDish { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
