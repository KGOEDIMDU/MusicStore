namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int songID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ratingValue { get; set; }

        [Required]
        [StringLength(50)]
        public string comment { get; set; }

        public DateTime dateSubmitted { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Song Song { get; set; }
    }
}
