namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Reviews = new HashSet<Review>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerID { get; set; }

        [Required]
        [StringLength(30)]
        public string firstname { get; set; }

        [Required]
        [StringLength(20)]
        public string lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
