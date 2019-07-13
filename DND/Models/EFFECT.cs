namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFFECT")]
    public partial class EFFECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EFFECT()
        {
            EFFECT_PROCEDURE = new HashSet<EFFECT_PROCEDURE>();
            ITEM_EFFECT = new HashSet<ITEM_EFFECT>();
            SPELLS_EFFECT = new HashSet<SPELLS_EFFECT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ef_id { get; set; }

        [StringLength(150)]
        public string ef_name { get; set; }

        public string ef_desc { get; set; }

        public bool? ef_hasprocedure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EFFECT_PROCEDURE> EFFECT_PROCEDURE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_EFFECT> ITEM_EFFECT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPELLS_EFFECT> SPELLS_EFFECT { get; set; }
    }
}