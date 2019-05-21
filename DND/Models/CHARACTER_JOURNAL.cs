namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARACTER_JOURNAL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cj_cid { get; set; }

        [Key]
        [Column(Order = 1)]
        public int cj_entryID { get; set; }

        public string cj_text { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
