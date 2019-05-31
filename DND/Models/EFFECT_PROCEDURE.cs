namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EFFECT_PROCEDURE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int efp_id { get; set; }

        public int efp_efid { get; set; }

        public string efp_procedure { get; set; }

        public virtual EFFECT EFFECT { get; set; }
    }
}
