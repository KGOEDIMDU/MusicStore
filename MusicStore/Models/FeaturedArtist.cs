namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeaturedArtist")]
    public partial class FeaturedArtist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int featCode { get; set; }

        public int songID { get; set; }

        public int artistID { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Song Song { get; set; }
    }
}
