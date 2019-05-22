namespace DND.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHARACTER")]
    public partial class CHARACTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHARACTER()
        {
            CAMPAIGN_PLAYER_CHARACTERS = new HashSet<CAMPAIGN_PLAYER_CHARACTERS>();
            CHARACTER_ATTACK = new HashSet<CHARACTER_ATTACK>();
            CHARACTER_CLASS = new HashSet<CHARACTER_CLASS>();
            CHARACTER_JOURNAL = new HashSet<CHARACTER_JOURNAL>();
            ITEM = new HashSet<ITEM>();
            BACKGROUND = new HashSet<BACKGROUND>();
            FEATS = new HashSet<FEATS>();
            PROFICIENCY = new HashSet<PROFICIENCY>();
            SKILL = new HashSet<SKILL>();
            SPELLS = new HashSet<SPELLS>();
            CAMPAIGN = new HashSet<CAMPAIGN>();
        }

        [Key]
        public int c_id { get; set; }

        [StringLength(100)]
        public string c_name { get; set; }

        public int? c_rid { get; set; }

        [StringLength(25)]
        public string c_alignment { get; set; }

        public int? c_hpcurrent { get; set; }

        public int? c_hpmax { get; set; }

        public int? c_hptemp { get; set; }

        public bool? c_inspiration { get; set; }

        public int? c_spellslots_remaining { get; set; }

        public int? c_spellslots_total { get; set; }

        public int? c_bid { get; set; }

        public bool? c_isNPC { get; set; }

        public int? c_armorclass { get; set; }

        public int? c_initiative { get; set; }

        public int? c_speed { get; set; }

        public int? c_experience { get; set; }

        public int? c_gold { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGN_PLAYER_CHARACTERS> CAMPAIGN_PLAYER_CHARACTERS { get; set; }

        public virtual CHARACTER_ABILITY CHARACTER_ABILITY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER_ATTACK> CHARACTER_ATTACK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER_CLASS> CHARACTER_CLASS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARACTER_JOURNAL> CHARACTER_JOURNAL { get; set; }

        public virtual RACE RACE { get; set; }

        public virtual SPELLS_SLOTS SPELLS_SLOTS { get; set; }

        public virtual SPELLS_SLOTS SPELLS_SLOTS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM> ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKGROUND> BACKGROUND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FEATS> FEATS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROFICIENCY> PROFICIENCY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILL> SKILL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPELLS> SPELLS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGN> CAMPAIGN { get; set; }
    }
}
