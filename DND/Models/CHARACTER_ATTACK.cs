namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARACTER_ATTACK
    {
        [Key]
        [Column(Order = 0)]
        public int a_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int a_cid { get; set; }

        [StringLength(250)]
        public string a_name { get; set; }

        [StringLength(25)]
        public string a_attackability { get; set; }

        public int? a_attackbonus { get; set; }

        public bool? a_isproficient { get; set; }

        [StringLength(25)]
        public string a_range { get; set; }

        [StringLength(50)]
        public string a_damage1 { get; set; }

        [StringLength(50)]
        public string a_damage2 { get; set; }

        public string a_description { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
