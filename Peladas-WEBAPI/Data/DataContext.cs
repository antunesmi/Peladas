using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Peladas_WEBAPI.Models;

namespace Peladas_WEBAPI.Data
{
    public class DataContext : DbContext //classe herdada do EF
    {public DataContext(DbContextOptions<DataContext> options) : base (options) { } //base é o construtor do dbcontext       
        //nomeclatura da tabela seguindo a classe
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pelada> Peladas { get; set; }
        public DbSet<LocalP> LocaisP { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //construção da chave 
            builder.Entity<Agendamento>()
                .HasKey(AD => new { AD.usuarioId, AD.peladaId });
            
            builder.Entity<Pelada>()
                .HasData(new List<Pelada>(){
                    new Pelada(1, "Grupo Ypiranga", "19/08/2022", "10:00", System.DateTime.Now, 1),
                    new Pelada(2, "Grupo Bahia", "17/08/2022", "12:00", System.DateTime.Now, 2 ),
                    new Pelada(3, "Grupo Vitória", "1/08/2022", "16:00", System.DateTime.Now, 3 ),
                    new Pelada(4, "Grupo Botafogo SSA", "5/08/2022", "18:00", System.DateTime.Now, 4 ),
                    new Pelada(5, "Grupo Leônico", "5/08/2022", "7:00", System.DateTime.Now, 5 ),
                    new Pelada(6, "Grupo Galícia", "30/08/2022", "8:00", System.DateTime.Now, 2 ),
                    new Pelada(7, "Grupo Cruzeiro do Sul", "20/08/2022", "9:30", System.DateTime.Now, 3),
                });
            
            builder.Entity<LocalP>()
                .HasData(new List<LocalP>{
                    new LocalP(1, "Ginásio Renato Manfredini" ,"Renato Russo" ),
                    new LocalP(2, "Ginásio Agenor Miranda","Cazuzão"),
                    new LocalP(3, "Quadra Carlos Leoni","Leoni"),
                    new LocalP(4, "Quadra Roberto Frejat","Frejat"),
                    new LocalP(5, "Campo Síntético Paulo Ricardo","PR")
                    
                });
            
            builder.Entity<Usuario>()
                .HasData(new List<Usuario>(){
                    new Usuario(1, "Marta Antunes", "Táta", "tata@gmail.com", "prodeb"),
                    new Usuario(2, "Paula Nascimento", "Paulinha", "Paulinha@gmail.com", "prodeb"),
                    new Usuario(3, "Laura Barros", "Laurinha", "tata@gmail.com", "prodeb"),
                    new Usuario(4, "Luiza Santiago", "Lúh", "luh@gmail.com", "prodeb"),
                    new Usuario(5, "Lucas Ferreira", "Kazão", "kazao@gmail.com", "prodeb"),
                    new Usuario(6, "Pedro Silva", "Pedroca", "droca@gmail.com", "prodeb"),
                    new Usuario(7, "Paulo Santos", "Paulito", "lito@gmail.com", "prodeb"),
                  
                });

            builder.Entity<Agendamento>()
                .HasData(new List<Agendamento>() {
                    new Agendamento() {usuarioId = 1, peladaId = 1 },
                    new Agendamento() {usuarioId = 2, peladaId = 2 },
                    new Agendamento() {usuarioId = 3, peladaId = 3 },
                    new Agendamento() {usuarioId = 4, peladaId = 4 },
                    new Agendamento() {usuarioId = 5, peladaId = 5 },
                    new Agendamento() {usuarioId = 1, peladaId = 3 },
                    new Agendamento() {usuarioId = 3, peladaId = 2 }

            });                   
                                    
        }           
    }
}