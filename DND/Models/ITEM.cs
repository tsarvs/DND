namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEM")]
    public partial class ITEM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int i_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int i_cid { get; set; }

        [StringLength(250)]
        public string i_name { get; set; }

        public int? i_quantity { get; set; }

        public decimal? i_weight { get; set; }

        public string i_description { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
