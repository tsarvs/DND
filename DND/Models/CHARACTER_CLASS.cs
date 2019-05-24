namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARACTER_CLASS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cc_cid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cc_clid { get; set; }

        public int? cc_level { get; set; }

        public int? cc_hitdice_current { get; set; }

        public int? cc_spellsave_dc { get; set; }

        public int? cc_spellattackbonus { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }

        public virtual CLASS CLASS { get; set; }
    }
}
