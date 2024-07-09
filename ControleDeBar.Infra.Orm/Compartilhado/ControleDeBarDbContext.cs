
using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControleDeBar.Infra.Orm.Compartilhado
{
    public class ControleDeBarDbContext : DbContext
    {
        public DbSet<Garcom> Garcons { get; internal set; }
        public DbSet<Produto> Produtos { get; internal set; }
        public DbSet<Pedido> Pedidos { get; internal set; }
        public DbSet<Mesa> Mesas { get; internal set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
               "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ControleDeBarOrm;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garcom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarcom");

                garcomBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                garcomBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                produtoBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                produtoBuilder.Property(d => d.Preco)
                .IsRequired().HasColumnType("decimal(18, 2)");

            });

        modelBuilder.Entity<Pedido>(pedidoBuilder =>
            {
                pedidoBuilder.ToTable("TBPedido");
                pedidoBuilder.Property(t => t.Id).IsRequired(true).ValueGeneratedOnAdd();
                pedidoBuilder.Property(t => t.Mesa).HasColumnType("varchar(250)").IsRequired();
     
                pedidoBuilder.HasOne(t => t.Garcom)
                    .WithMany()
                    .IsRequired()
                    .HasForeignKey("Garcom_Id")
                    .HasConstraintName("FK_TBPedido_TBGarcom")
                    .OnDelete(DeleteBehavior.NoAction);

                

                pedidoBuilder.HasMany(t => t.Produtos)
                    .WithMany()
                    .UsingEntity(x => x.ToTable("TBPedido_TBProduto"));

                pedidoBuilder.Property(d => d.Total)
                .IsRequired().HasColumnType("decimal(18, 2)");
                pedidoBuilder.Property(t => t.Data).HasColumnType("datetime").IsRequired();
                pedidoBuilder.Property(t => t.Situacao).HasColumnType("varchar(10)").IsRequired();
            });


            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                mesaBuilder.Property(d => d.Numero)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
