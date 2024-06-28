﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                            CriadoEm = new DateTime(2024, 6, 29, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8760),
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                            CriadoEm = new DateTime(2024, 6, 30, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8772),
                            Nome = "Estudos"
                        },
                        new
                        {
                            CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                            CriadoEm = new DateTime(2024, 7, 1, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8778),
                            Nome = "Descontração"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.Property<string>("TarefaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("TarefaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            TarefaId = "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                            CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                            CriadoEm = new DateTime(2024, 7, 5, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8864),
                            Descricao = "Fazer um resumo do livro lido",
                            Status = "Não iniciada",
                            Titulo = "Terminar estudo de um Livro"
                        },
                        new
                        {
                            TarefaId = "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                            CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                            CriadoEm = new DateTime(2024, 7, 1, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8879),
                            Descricao = "Se preparando para as Provas Finais",
                            Status = "Não iniciada",
                            Titulo = "Tempo de estudo"
                        },
                        new
                        {
                            TarefaId = "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                            CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                            CriadoEm = new DateTime(2024, 7, 12, 9, 34, 52, 693, DateTimeKind.Local).AddTicks(8886),
                            Descricao = "Se distrair um pouco e levar os cachorros para passear",
                            Status = "Não iniciada",
                            Titulo = "Sair com os Dogs"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.HasOne("API.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
