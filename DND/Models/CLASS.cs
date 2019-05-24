namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASS")]
    public partial class CLASS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASS()
        {
            CHARACTER_CLASS = new HashSet<CHARACTER_CLASS>();
        }

        [Key]
        public int cl_id { get; set; }

        [StringLength(50)]
        public string cl_name { get; set; }

        [StringLength(10)]
        public string cl_hitdicetype { get; set; }

        [StringLength(10)]
        public string cl_spellcastingability { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER_CLASS> CHARACTER_CLASS { get; set; }
    }
}
