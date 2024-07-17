﻿// <auto-generated />
using System;
using FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240716224241_AddStatusPagamentoToPedido")]
    partial class AddStatusPagamentoToPedido
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormasPagamento");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.ItemDePedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("PedidoId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensDePedido");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataEncerrado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPreparacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPronto")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FormaPagamentoId")
                        .HasColumnType("int");

                    b.Property<Guid>("IdGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("int");

                    b.Property<int>("StatusPedido")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaPagamentoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.ItemDePedido", b =>
                {
                    b.HasOne("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItensDePedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId");

                    b.Navigation("Cliente");

                    b.Navigation("FormaPagamento");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Produto", b =>
                {
                    b.HasOne("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Categoria", "CategoriaProduto")
                        .WithMany()
                        .HasForeignKey("CategoriaProdutoId");

                    b.Navigation("CategoriaProduto");
                });

            modelBuilder.Entity("FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("ItensDePedido");
                });
#pragma warning restore 612, 618
        }
    }
}
