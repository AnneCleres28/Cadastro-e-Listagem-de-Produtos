using CadastroEListagemDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroEListagemDeProdutos.Core.DataBase
{
    public class DataBase : DbContext
    {
        protected const string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anne_\\Documents\\LocalDb.mdf;Integrated Security=True;Connect Timeout=30";

        public DataBase()
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().ToTable("Produtos");

            //ID
            modelBuilder.Entity<Produto>().HasKey(x => x.Id);
            modelBuilder.Entity<Produto>().Property(x => x.Id).UseIdentityColumn().IsRequired();

            //Nome
            modelBuilder.Entity<Produto>().Property(x => x.Nome).HasMaxLength(25).IsRequired();

            //Descriçao
            modelBuilder.Entity<Produto>().Property(x => x.Descricao).HasMaxLength(125).IsRequired();

            //Valor
            modelBuilder.Entity<Produto>().Property(x => x.Valor).HasDefaultValue(0);

            //Disponivel
            modelBuilder.Entity<Produto>().Property(x => x.Disponivel).HasDefaultValue(false);
        }
    }
}
