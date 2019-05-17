namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SPELLS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPELLS()
        {
            CHARACTER = new HashSet<CHARACTER>();
        }

        [Key]
        public int s_id { get; set; }

        [StringLength(250)]
        public string s_name { get; set; }

        [StringLength(100)]
        public string s_school { get; set; }

        public int? s_castingtimeminutes { get; set; }

        [StringLength(10)]
        public string s_range { get; set; }

        [StringLength(100)]
        public string s_target { get; set; }

        public bool? s_component_v { get; set; }

        public bool? s_component_s { get; set; }

        [StringLength(250)]
        public string s_component_m { get; set; }

        public bool? s_isconcentration { get; set; }

        public int? s_durationminutes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }
    }
}
