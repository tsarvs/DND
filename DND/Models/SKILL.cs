namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SKILL")]
    public partial class SKILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SKILL()
        {
            CHARACTER = new HashSet<CHARACTER>();
        }

        [Key]
        public int s_id { get; set; }

        public int? s_animalhandling { get; set; }

        public int? s_arcana { get; set; }

        public int? s_athletics { get; set; }

        public int? s_deception { get; set; }

        public int? s_history { get; set; }

        public int? s_insight { get; set; }

        public int? s_intimidation { get; set; }

        public int? s_medicine { get; set; }

        public int? s_nature { get; set; }

        public int? s_perception { get; set; }

        public int? s_performance { get; set; }

        public int? s_persuasion { get; set; }

        public int? s_religion { get; set; }

        public int? s_sleightofhand { get; set; }

        public int? s_stealth { get; set; }

        public int? s_survival { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER> CHARACTER { get; set; }
    }
}
