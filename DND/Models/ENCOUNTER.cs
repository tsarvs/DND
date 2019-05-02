namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ENCOUNTER")]
    public partial class ENCOUNTER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int e_id { get; set; }

        public int? e_lid { get; set; }

        public string e_desc { get; set; }

        public virtual LOCATION LOCATION { get; set; }
    }
}
