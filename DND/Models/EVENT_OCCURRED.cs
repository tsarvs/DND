namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVENT_OCCURRED
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENT_OCCURRED()
        {
            EVENT_TYPE = new HashSet<EVENT_TYPE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eo_id { get; set; }

        public int? eo_lid { get; set; }

        public string eo_desc { get; set; }

        public DateTime? eo_start { get; set; }

        public DateTime? eo_end { get; set; }

        public virtual LOCATION LOCATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENT_TYPE> EVENT_TYPE { get; set; }
    }
}
