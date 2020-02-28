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

        public virtual DbSet<ABILITY> ABILITY { get; set; }
        public virtual DbSet<CAMPAIGN> CAMPAIGN { get; set; }
        public virtual DbSet<CAMPAIGN_PLAYER_CHARACTERS> CAMPAIGN_PLAYER_CHARACTERS { get; set; }
        public virtual DbSet<CHARACTER> CHARACTER { get; set; }
        public virtual DbSet<CHARACTER_ATTACK> CHARACTER_ATTACK { get; set; }
        public virtual DbSet<CHARACTER_BACKGROUND> CHARACTER_BACKGROUND { get; set; }
        public virtual DbSet<CHARACTER_CLASS> CHARACTER_CLASS { get; set; }
        public virtual DbSet<CHARACTER_JOURNAL> CHARACTER_JOURNAL { get; set; }
        public virtual DbSet<CLASS> CLASS { get; set; }
        public virtual DbSet<ENCOUNTER> ENCOUNTER { get; set; }
        public virtual DbSet<EPISODE> EPISODE { get; set; }
        public virtual DbSet<EVENT_OCCURRED> EVENT_OCCURRED { get; set; }
        public virtual DbSet<EVENT_TYPE> EVENT_TYPE { get; set; }
        public virtual DbSet<FEATS> FEATS { get; set; }
        public virtual DbSet<ITEM> ITEM { get; set; }
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
            modelBuilder.Entity<ABILITY>()
                .HasMany(e => e.CHARACTER)
                .WithOptional(e => e.ABILITY)
                .HasForeignKey(e => e.c_aid);

            modelBuilder.Entity<ABILITY>()
                .HasMany(e => e.RACE)
                .WithOptional(e => e.ABILITY)
                .HasForeignKey(e => e.r_aid);

            modelBuilder.Entity<CAMPAIGN>()
                .Property(e => e.cmp_name)
                .IsUnicode(false);

            modelBuilder.Entity<CAMPAIGN>()
                .Property(e => e.cmp_dm)
                .IsUnicode(false);

            modelBuilder.Entity<CAMPAIGN>()
                .Property(e => e.cmp_description)
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
                .HasMany(e => e.CHARACTER_ATTACK)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.a_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_BACKGROUND)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.cb_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_CLASS)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.cc_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.CHARACTER_JOURNAL)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.cj_cid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHARACTER>()
                .HasMany(e => e.ITEM)
                .WithRequired(e => e.CHARACTER)
                .HasForeignKey(e => e.i_cid)
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
                .HasMany(e => e.SPELLS)
                .WithMany(e => e.CHARACTER)
                .Map(m => m.ToTable("CHARACTER_SPELLBOOK").MapLeftKey("cs_cid").MapRightKey("cs_sid"));

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_name)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_attackability)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_range)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_damage1)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_damage2)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_ATTACK>()
                .Property(e => e.a_description)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_BACKGROUND>()
                .Property(e => e.cb_title)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_BACKGROUND>()
                .Property(e => e.cb_description)
                .IsUnicode(false);

            modelBuilder.Entity<CHARACTER_JOURNAL>()
                .Property(e => e.cj_text)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.cl_name)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.cl_hitdicetype)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.cl_spellcastingability)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .HasMany(e => e.CHARACTER_CLASS)
                .WithRequired(e => e.CLASS)
                .HasForeignKey(e => e.cc_clid)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.i_name)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.i_weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.i_description)
                .IsUnicode(false);

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
                .Property(e => e.r_description)
                .IsUnicode(false);

            modelBuilder.Entity<RACE>()
                .HasMany(e => e.CHARACTER)
                .WithOptional(e => e.RACE)
                .HasForeignKey(e => e.c_rid);

            modelBuilder.Entity<SKILL>()
                .HasMany(e => e.CHARACTER)
                .WithOptional(e => e.SKILL)
                .HasForeignKey(e => e.c_sid);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_name)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_school)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_castingtime)
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

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_durationminutes)
                .IsUnicode(false);

            modelBuilder.Entity<SPELLS>()
                .Property(e => e.s_description)
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
