namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int albumID { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        public string albumCover { get; set; }

        [Column(TypeName = "date")]
        public DateTime yearReleased { get; set; }

        public int artistID { get; set; }

        public virtual Artist Artist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song> Songs { get; set; }
    }
}
