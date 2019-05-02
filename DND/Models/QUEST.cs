namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUEST")]
    public partial class QUEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUEST()
        {
            BACKGROUND = new HashSet<BACKGROUND>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int q_id { get; set; }

        public int q_qlid { get; set; }

        public string q_title { get; set; }

        public string q_desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? q_startdate { get; set; }

        public int? q_next { get; set; }

        public virtual QUESTLINE QUESTLINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKGROUND> BACKGROUND { get; set; }
    }
}
