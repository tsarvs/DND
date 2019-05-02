namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EPISODE")]
    public partial class EPISODE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ep_id { get; set; }

        public int ep_cmpid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ep_date { get; set; }

        public string ep_desc { get; set; }

        public virtual CAMPAIGN CAMPAIGN { get; set; }
    }
}
