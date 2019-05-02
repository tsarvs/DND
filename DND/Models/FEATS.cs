namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FEATS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FEATS()
        {
            CHARACTER = new HashSet<CHARACTER>();
        }

        [Key]
        public int f_id { get; set; }

        [StringLength(100)]
        public string f_name { get; set; }

        [StringLength(100)]
        public string f_source { get; set; }

        public string f_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }
    }
}
