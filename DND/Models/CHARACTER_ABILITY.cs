namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARACTER_ABILITY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_cid { get; set; }

        public int? ca_CHA { get; set; }

        public int? ca_CON { get; set; }

        public int? ca_DEX { get; set; }

        public int? ca_INT { get; set; }

        public int? ca_STR { get; set; }

        public int? ca_WIS { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
