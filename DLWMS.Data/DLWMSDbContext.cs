using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        //‪C:\Users\online\Desktop\DLWMS.db

        private string dbPutanja;

	   public DLWMSDbContext()// : base("C:\\Users\\online\\Desktop\\DLWMS.db")
	   {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSPutanja"].ConnectionString;
	   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(student => student.Uloga)
                .WithMany(uloga => uloga.Student)
                .UsingEntity(medjuTabela => medjuTabela.ToTable("StudentiUloge"));
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Uloga> Uloge { get; set; }

        public DbSet<StudentPredmet> StudentiPredmeti{ get; set; }



    }
}
