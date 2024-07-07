
using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
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






            //modelBuilder.Entity<Materia>(materiaBuilder =>
            //{
            //    materiaBuilder.ToTable("TBMateria");
            //    materiaBuilder.Property(m => m.Id)
            //        .IsRequired()
            //        .ValueGeneratedOnAdd();

            //    materiaBuilder.Property(m => m.Nome)
            //       .IsRequired()
            //       .HasColumnType("varchar(250)");

            //    materiaBuilder.Property(m => m.Serie)
            //        .IsRequired()
            //        .HasConversion<int>();

            //    materiaBuilder.HasOne(m => m.Disciplina)
            //        .WithMany(d => d.Materias)
            //        .IsRequired()
            //        .HasForeignKey("Disciplina_Id")
            //        .HasConstraintName("FK_TBMateria_TBDisciplina")
            //        .OnDelete(DeleteBehavior.Restrict);
            //});

            //modelBuilder.Entity<Questao>(questaoBuilder =>
            //{

            //    questaoBuilder.ToTable("TBQuestao");
            //    questaoBuilder.Property(q => q.Id).IsRequired().ValueGeneratedOnAdd();
            //    questaoBuilder.Property(q => q.Enunciado).HasColumnType("varchar(500)").IsRequired();
            //    questaoBuilder.Property(q => q.UtilizadaEmTeste).IsRequired();

            //    questaoBuilder.HasOne(q => q.Materia)
            //        .WithMany(m => m.Questoes)
            //        .IsRequired()
            //        .HasForeignKey("Materia_Id")
            //        .HasConstraintName("FK_TBQuestao_TBMateria")
            //        .OnDelete(DeleteBehavior.Restrict);
            //});

            //modelBuilder.Entity<Alternativa>(alternativaBuilder =>
            //{
            //    alternativaBuilder.ToTable("TBAlternativa");
            //    alternativaBuilder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
            //    alternativaBuilder.Property(a => a.Letra).IsRequired();
            //    alternativaBuilder.Property(a => a.Resposta).HasColumnType("varchar(100)").IsRequired();
            //    alternativaBuilder.Property(a => a.Correta).IsRequired();

            //    alternativaBuilder.HasOne(a => a.Questao)
            //        .WithMany(q => q.Alternativas)
            //        .IsRequired()
            //        .HasForeignKey("Questao_Id")
            //        .HasConstraintName("FK_TBAlternativa_TBQuestao")
            //        .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<Teste>(testeBuilder =>
            //{
            //    testeBuilder.ToTable("TBTeste");
            //    testeBuilder.Property(t => t.Id).IsRequired(true).ValueGeneratedOnAdd();
            //    testeBuilder.Property(t => t.Titulo).HasColumnType("varchar(250)").IsRequired();
            //    testeBuilder.Property(t => t.DataGeracao).IsRequired();
            //    testeBuilder.Property(t => t.ProvaRecuperacao).IsRequired();

            //    testeBuilder.HasOne(t => t.Disciplina)
            //        .WithMany()
            //        .IsRequired()
            //        .HasForeignKey("Disciplina_Id")
            //        .HasConstraintName("FK_TBTeste_TBDisciplina")
            //        .OnDelete(DeleteBehavior.NoAction);

            //    testeBuilder.HasOne(t => t.Materia)
            //        .WithMany()
            //        .IsRequired(false)
            //        .HasForeignKey("Materia_Id")
            //        .HasConstraintName("FK_TBTeste_TBMateria")
            //    .OnDelete(DeleteBehavior.NoAction);

            //    testeBuilder.HasMany(t => t.Questoes)
            //        .WithMany()
            //        .UsingEntity(x => x.ToTable("TBTeste_TBQuestao"));
            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}
