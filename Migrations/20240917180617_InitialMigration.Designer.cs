﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pim2024_FazendaUrbana.Data;

#nullable disable

namespace Pim2024_FazendaUrbana.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240917180617_InitialMigration")]
    partial class InitialMigration
    {

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Usuario_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Usuario_ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.ControleProducao", b =>
                {
                    b.Property<int>("ControleProdu_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ControleProdu_ID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataConclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ControleProdu_ID");

                    b.ToTable("ControleProducoes");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Funcionario", b =>
                {
                    b.Property<int>("Fun_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fun_ID"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Genero")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Usuario_ID")
                        .HasColumnType("int");

                    b.HasKey("Fun_ID");

                    b.HasIndex("Usuario_ID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Insumo", b =>
                {
                    b.Property<int>("Insumo_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Insumo_ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Insumo_ID");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemVenda_ID")
                        .HasColumnType("int");

                    b.Property<float>("PrecoVenda")
                        .HasColumnType("real");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Venda_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("Venda_ID");

                    b.ToTable("ItensVenda");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FornecedorFun_ID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorFun_ID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Usuario", b =>
                {
                    b.Property<int>("Usuario_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usuario_ID"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuario_ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Venda", b =>
                {
                    b.Property<int>("Venda_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Venda_ID"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncionarioFun_ID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("real");

                    b.HasKey("Venda_ID");

                    b.HasIndex("FuncionarioFun_ID");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.HasOne("Pim2024_FazendaUrbana.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuario_ID");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Funcionario", b =>
                {
                    b.HasOne("Pim2024_FazendaUrbana.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuario_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.ItemVenda", b =>
                {
                    b.HasOne("Pim2024_FazendaUrbana.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pim2024_FazendaUrbana.Models.Venda", "Venda")
                        .WithMany("ItensVenda")
                        .HasForeignKey("Venda_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Produto", b =>
                {
                    b.HasOne("Pim2024_FazendaUrbana.Models.Funcionario", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorFun_ID");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Venda", b =>
                {
                    b.HasOne("Pim2024_FazendaUrbana.Models.Funcionario", null)
                        .WithMany("Pedidos")
                        .HasForeignKey("FuncionarioFun_ID");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Funcionario", b =>
                {
                    b.Navigation("Pedidos");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Pim2024_FazendaUrbana.Models.Venda", b =>
                {
                    b.Navigation("ItensVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
