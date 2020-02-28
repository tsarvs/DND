namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARACTER_BACKGROUND
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cb_cid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cb_id { get; set; }

        [StringLength(100)]
        public string cb_title { get; set; }

        public string cb_description { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
