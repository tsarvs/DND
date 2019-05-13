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
        public int a_id { get; set; }

        public int? a_cid { get; set; }

        public int? a_attackability { get; set; }

        public bool? a_isproficient { get; set; }

        [StringLength(10)]
        public string a_range { get; set; }

        [StringLength(50)]
        public string a_damage1 { get; set; }

        [StringLength(50)]
        public string a_damage2 { get; set; }

        public string a_itemdescription { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
