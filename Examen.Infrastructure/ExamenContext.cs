
using Examen.ApplicationCore.Domaine;
using Examen.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Fete> Fetes { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Salle> Salles { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ISMAEL\SQLEXPRESS01;
 Initial Catalog=FeteElgharnouguiIsmail;Integrated Security=true;
 User ID=ISMAEL  ; Password=ismael150  ;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new InvitationConfiguration());


            modelBuilder.Entity<Invite>().HasMany(p => p.Invitations)
                .WithOne(r => r.Invite).HasForeignKey(p => p.InviteFk);


            // Cônfig de FeteFK
            modelBuilder.Entity<Invitation>().HasOne(r => r.Fete)
               .WithMany(t => t.Invitations).HasForeignKey(p => p.FeteFk);
               



        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
              configurationBuilder.Properties<string>().HaveMaxLength(150);


        }
    }
}
