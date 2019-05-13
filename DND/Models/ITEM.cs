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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITEM()
        {
            CHARACTER_INVENTORY = new HashSet<CHARACTER_INVENTORY>();
            EFFECT = new HashSet<EFFECT>();
        }

        [Key]
        public int i_id { get; set; }

        public decimal? i_weight { get; set; }

        public decimal? i_gp { get; set; }

        public string i_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER_INVENTORY> CHARACTER_INVENTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EFFECT> EFFECT { get; set; }
    }
}
