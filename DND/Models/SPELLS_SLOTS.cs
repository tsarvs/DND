namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SPELLS_SLOTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPELLS_SLOTS()
        {
            CHARACTER = new HashSet<CHARACTER>();
            CHARACTER1 = new HashSet<CHARACTER>();
        }

        [Key]
        public int ss_id { get; set; }

        public int? ss_lvl1 { get; set; }

        public int? ss_lvl2 { get; set; }

        public int? ss_lvl3 { get; set; }

        public int? ss_lvl4 { get; set; }

        public int? ss_lvl5 { get; set; }

        public int? ss_lvl6 { get; set; }

        public int? ss_lvl7 { get; set; }

        public int? ss_lvl8 { get; set; }

        public int? ss_lvl9 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER1 { get; set; }
    }
}
