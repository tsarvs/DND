namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABILITY")]
    public partial class ABILITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ABILITY()
        {
            CHARACTER = new HashSet<CHARACTER>();
            RACE = new HashSet<RACE>();
        }

        [Key]
        public int a_id { get; set; }

        public int? a_STR { get; set; }

        public int? a_DEX { get; set; }

        public int? a_WIS { get; set; }

        public int? a_CON { get; set; }

        public int? a_CHA { get; set; }

        public int? a_INT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RACE> RACE { get; set; }
    }
}
