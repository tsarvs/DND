namespace DND.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DragonDBModel : DbContext
    {
        public DragonDBModel()
            : base("name=DragonDBModel")
        {
        }

        public virtual DbSet<BACKGROUND> BACKGROUND { get; set; }
        public virtual DbSet<CAMPAIGN> CAMPAIGN { get; set; }
        public virtual DbSet<CAMPAIGN_PLAYER_CHARACTERS> CAMPAIGN_PLAYER_CHARACTERS { get; set; }
        public virtual DbSet<CHARACTER> CHARACTER { get; set; }
        public virtual DbSet<CHARACTER_ABILITY> CHARACTER_ABILITY { get; set; }
        public virtual DbSet<CHARACTER_ATTACK> CHARACTER_ATTACK { get; set; }
        public virtual DbSet<CHARACTER_CLASS> CHARACTER_CLASS { get; set; }
        public virtual DbSet<CHARACTER_INVENTORY> CHARACTER_INVENTORY { get; set; }
        public virtual DbSet<CLASS> CLASS { get; set; }
        public virtual DbSet<EFFECT> EFFECT { get; set; }
        public virtual DbSet<EFFECT_PROCEDURE> EFFECT_PROCEDURE { get; set; }
        public virtual DbSet<ENCOUNTER> ENCOUNTER { get; set; }
        public virtual DbSet<EPISODE> EPISODE { get; set; }
        public virtual DbSet<EVENT_OCCURRED> EVENT_OCCURRED { get; set; }
        public virtual DbSet<EVENT_TYPE> EVENT_TYPE { get; set; }
        public virtual DbSet<FEATS> FEATS { get; set; }
        public virtual DbSet<ITEM> ITEM { get; set; }
        public virtual DbSet<ITEM_BACKGROUND> ITEM_BACKGROUND { get; set; }
        public virtual DbSet<LOCATION> LOCATION { get; set; }
        public virtual DbSet<PROFICIENCY> PROFICIENCY { get; set; }
        public virtual DbSet<QUEST> QUEST { get; set; }
        public virtual DbSet<QUESTLINE> QUESTLINE { get; set; }
        public virtual DbSet<RACE> RACE { get; set; }
        public virtual DbSet<SKILL> SKILL { get; set; }
        public virtual DbSet<SPELLS> SPELLS { get; set; }
        public virtual DbSet<SPELLS_SLOTS> SPELLS_SLOTS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BACKGROUND>()
                .Property(e => e.b_desc)
                .IsUnicode(false);

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.ITEM_BACKGROUND)
                .WithRequired(e => e.BACKGROUND)
                .HasForeignKey(e => e.ib_bid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.CAMPAIGN)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("CAMPAIGN_BACKGROUND").MapLeftKey("cmpb_bid").MapRightKey("cmpb_cmpid"));

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.CHARACTER)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("CHARACTER_BACKGROUND").MapLeftKey("cb_bid").MapRightKey("cb_cid"));

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.LOCATION)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("LOCATION_BACKGROUND").MapLeftKey("lb_bid").MapRightKey("lb_lid"));

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.QUEST)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("QUEST_BACKGROUND").MapLeftKey("qb_bid").MapRightKey("qb_qid"));

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.QUESTLINE)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("QUESTLINE_BACKGROUND").MapLeftKey("qlb_bid").MapRightKey("qlb_qlid"));

            modelBuilder.Entity<BACKGROUND>()
                .HasMany(e => e.RACE)
                .WithMany(e => e.BACKGROUND)
                .Map(m => m.ToTable("RACE_BACKGROUND").MapLeftKey("rb_bid").MapRightKey("rb_rid"));

            modelBuilder.Entity<CAMPAIGN>()
                .Property(e => e.cmp_name)
                .IsUnicode(false);

            modelBuilder.Entity<CAMPAIGN>()
                .Property(e => e.cmp_dm)
                .IsUnicode(false);

            modelBuilder.Entity<CAMPAIGN>()
                .HasOptional(e => e.CAMPAIGN_PLAYER_CHARACTERS)
                .WithRequired(e => e.CAMPAIGN);

            modelBuilder.Entity<CAMPAIGN>()
                .HasMany(e => e.EPISODE)
                .WithRequired(e => e.CAMPAIGN)
                .HasForeignKey(e => e.ep_cmpid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAMPAIGN>()
                .HasMany(e => e.QUESTLINE)
                .WithRequired(e => e.CAMPAIGN)
                .HasForeignKey(e => e.q_cmpid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAMPAIGN>()
                .HasMany(e => e.CHARACTER)
                .WithMany(e => e.CAMPAIGN)
                .Map(m => m.ToTable("GRAVEYARD").MapLeftKey("g_cmpid").MapRightKey("g_cid"));

            modelBuilder.Entity<CAMPAIGN_PLAYER_CHARACTERS>()
                .Property(e => e.cpc_playedby)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER>()
                .Property(e => e.c_name)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER>()
                .Property(e => e.c_alignment)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CAMPAIGN_PLAYER_CHARACTERS)
                .WithOptional(e => e.CHARACTER)
                .HasForeignKey(e => e.cpc_cid);

            modelBuilder.Entity<CHARACTER>()
                .HasOptional(e => e.CHARACTER_ABILITY)
                .WithRequired(e => e.CHARACTER);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_ATTACK)
                .WithOptional(e => e.CHARACTER)
                .HasForeignKey(e => e.a_cid);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_CLASS)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.cc_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_INVENTORY)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.ci_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.FEATS)
                .WithMany(e => e.CHARACTER)
                .Map(m => m.ToTable("CHARACTER_FEATS").MapLeftKey("cf_cid").MapRightKey("cf_fid"));

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.PROFICIENCY)
                .WithMany(e => e.CHARACTER)
                .Map(m => m.ToTable("CHARACTER_PROFICIENCIES").MapLeftKey("cp_cid").MapRightKey("cp_pid"));

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.SKILL)
                .WithMany(e => e.CHARACTER)
                .Map(m => m.ToTable("CHARACTER_SKILL").MapLeftKey("cs_cid").MapRightKey("cs_sid"));

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.SPELLS)
                .WithMany(e => e.CHARACTER)
                .Map(m => m.ToTable("CHARACTER_SPELLBOOK").MapLeftKey("cs_cid").MapRightKey("cs_sid"));

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_range)
                .IsFixedLength();

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_damage1)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_damage2)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_itemdescription)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.cl_name)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .HasMany(e => e.CHARACTER_CLASS)
                .WithRequired(e => e.CLASS)
                .HasForeignKey(e => e.cc_clid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EFFECT>()
                .Property(e => e.ef_name)
                .IsUnicode(false);

            modelBuilder.Entity<EFFECT>()
                .Property(e => e.ef_desc)
                .IsUnicode(false);

            modelBuilder.Entity<EFFECT>()
                .HasMany(e => e.EFFECT_PROCEDURE)
                .WithRequired(e => e.EFFECT)
                .HasForeignKey(e => e.efp_efid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EFFECT>()
                .HasMany(e => e.ITEM)
                .WithMany(e => e.EFFECT)
                .Map(m => m.ToTable("ITEM_EFFECT").MapLeftKey("if_efid").MapRightKey("ie_iid"));

            modelBuilder.Entity<EFFECT>()
                .HasMany(e => e.SPELLS)
                .WithMany(e => e.EFFECT)
                .Map(m => m.ToTable("SPELLS_EFFECT").MapLeftKey("sef_efid").MapRightKey("sef_sid"));

            modelBuilder.Entity<EFFECT_PROCEDURE>()
                .Property(e => e.efp_procedure)
                .IsUnicode(false);

            modelBuilder.Entity<ENCOUNTER>()
                .Property(e => e.e_desc)
                .IsUnicode(false);

            modelBuilder.Entity<EPISODE>()
                .Property(e => e.ep_desc)
                .IsUnicode(false);

            modelBuilder.Entity<EVENT_OCCURRED>()
                .Property(e => e.eo_desc)
                .IsUnicode(false);

            modelBuilder.Entity<EVENT_OCCURRED>()
                .HasMany(e => e.EVENT_TYPE)
                .WithMany(e => e.EVENT_OCCURRED)
                .Map(m => m.ToTable("EVENT_OCCURRED_TYPES").MapLeftKey("eot_eoid").MapRightKey("eot_etid"));

            modelBuilder.Entity<EVENT_TYPE>()
                .Property(e => e.et_name)
                .IsUnicode(false);

            modelBuilder.Entity<FEATS>()
                .Property(e => e.f_name)
                .IsUnicode(false);

            modelBuilder.Entity<FEATS>()
                .Property(e => e.f_source)
                .IsUnicode(false);

            modelBuilder.Entity<FEATS>()
                .Property(e => e.f_description)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.i_weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.i_gp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.i_description)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .HasMany(e => e.CHARACTER_INVENTORY)
                .WithRequired(e => e.ITEM)
                .HasForeignKey(e => e.ci_iid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.l_name)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.ENCOUNTER)
                .WithOptional(e => e.LOCATION)
                .HasForeignKey(e => e.e_lid);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.EVENT_OCCURRED)
                .WithOptional(e => e.LOCATION)
                .HasForeignKey(e => e.eo_lid);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.LOCATION1)
                .WithMany(e => e.LOCATION2)
                .Map(m => m.ToTable("SUBLOCATION").MapLeftKey("sl_child").MapRightKey("sl_parent"));

            modelBuilder.Entity<PROFICIENCY>()
                .Property(e => e.p_name)
                .IsUnicode(false);

            modelBuilder.Entity<PROFICIENCY>()
                .Property(e => e.p_type)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST>()
                .Property(e => e.q_title)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST>()
                .Property(e => e.q_desc)
                .IsUnicode(false);

            modelBuilder.Entity<QUESTLINE>()
                .Property(e => e.ql_title)
                .IsUnicode(false);

            modelBuilder.Entity<QUESTLINE>()
                .Property(e => e.ql_description)
                .IsUnicode(false);

            modelBuilder.Entity<QUESTLINE>()
                .HasMany(e => e.QUEST)
                .WithRequired(e => e.QUESTLINE)
                .HasForeignKey(e => e.q_qlid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RACE>()
                .Property(e => e.r_name)
                .IsUnicode(false);

            modelBuilder.Entity<RACE>()
                .HasMany(e => e.CHARACTER)
                .WithOptional(e => e.RACE)
                .HasForeignKey(e => e.c_rid);

            modelBuilder.Entity<RACE>()
                .HasMany(e => e.SKILL)
                .WithMany(e => e.RACE)
                .Map(m => m.ToTable("RACE_SKILL").MapLeftKey("rs_rid").MapRightKey("rs_sid"));

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_name)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_school)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_range)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_target)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_component_m)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS_SLOTS>()
                .HasMany(e => e.CHARACTER)
                .WithOptional(e => e.SPELLS_SLOTS)
                .HasForeignKey(e => e.c_spellslots_remaining);

            modelBuilder.Entity<SPELLS_SLOTS>()
                .HasMany(e => e.CHARACTER1)
                .WithOptional(e => e.SPELLS_SLOTS1)
                .HasForeignKey(e => e.c_spellslots_total);
        }
    }
}
