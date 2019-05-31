namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RACE")]
    public partial class RACE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RACE()
        {
            CHARACTER = new HashSet<CHARACTER>();
            RACE_SKILL = new HashSet<RACE_SKILL>();
            BACKGROUND = new HashSet<BACKGROUND>();
        }

        [Key]
        public int r_id { get; set; }

        [StringLength(100)]
        public string r_name { get; set; }

        public string r_description { get; set; }

        public int? r_aid { get; set; }

        public virtual ABILITY ABILITY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RACE_SKILL> RACE_SKILL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKGROUND> BACKGROUND { get; set; }
    }
}
