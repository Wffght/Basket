﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace баскетбол
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NBAShortEntities : DbContext
    {
        public NBAShortEntities()
            : base("name=NBAShortEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Matchup> Matchups { get; set; }
        public virtual DbSet<MatchupType> MatchupTypes { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerInTeam> PlayerInTeams { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PostSeason> PostSeasons { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
