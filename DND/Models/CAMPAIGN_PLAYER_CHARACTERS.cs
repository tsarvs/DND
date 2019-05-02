namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAMPAIGN_PLAYER_CHARACTERS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cpc_cmpid { get; set; }

        public int? cpc_cid { get; set; }

        [StringLength(100)]
        public string cpc_playedby { get; set; }

        public virtual CAMPAIGN CAMPAIGN { get; set; }

        public virtual CHARACTER CHARACTER { get; set; }
    }
}
