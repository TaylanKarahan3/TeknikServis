//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServisWeb.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_UrunTakip> Tbl_UrunTakip { get; set; }
        public virtual DbSet<Tbl_Hakkimizda> Tbl_Hakkimizda { get; set; }
        public virtual DbSet<Tbl_Urun> Tbl_Urun { get; set; }
        public virtual DbSet<Tbl_İletisim> Tbl_İletisim { get; set; }
    }
}
