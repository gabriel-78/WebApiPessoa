using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPessoa2.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().Property(p => p.Cpf).HasMaxLength(11);
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasMaxLength(30);
            modelBuilder.Entity<Pessoa>().Property(p => p.Sobrenome).HasMaxLength(80);
            modelBuilder.Entity<Pessoa>().Property(p => p.Email).HasMaxLength(80);

            modelBuilder.Entity<Pessoa>().HasData(
                    new Pessoa { Id = 1, Cpf = "00000000001", Nome = "Gabriel", Sobrenome = "de Almeida", Email = "gabriel@gmail.com"},
                    new Pessoa { Id = 2, Cpf = "00000000002", Nome = "Rosana", Sobrenome = "Maia", Email = "rosana@gmail.com" },
                    new Pessoa { Id = 3, Cpf = "00000000003", Nome = "Rayanna", Sobrenome = "Almeida", Email = "rayanna@gmail.com" });
        }
    }
}
