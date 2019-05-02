namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAMPAIGN")]
    public partial class CAMPAIGN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAMPAIGN()
        {
            EPISODE = new HashSet<EPISODE>();
            QUESTLINE = new HashSet<QUESTLINE>();
            BACKGROUND = new HashSet<BACKGROUND>();
            CHARACTER = new HashSet<CHARACTER>();
        }

        [Key]
        public int cmp_id { get; set; }

        [StringLength(250)]
        public string cmp_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cmp_startdate { get; set; }

        [StringLength(50)]
        public string cmp_dm { get; set; }

        public virtual CAMPAIGN_PLAYER_CHARACTERS CAMPAIGN_PLAYER_CHARACTERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EPISODE> EPISODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUESTLINE> QUESTLINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKGROUND> BACKGROUND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }
    }
}
