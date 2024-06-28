﻿using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class AppDataContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Jean.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", Nome = "Trabalho", CriadoEm = DateTime.Now.AddDays(1) },
            new Categoria { CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", Nome = "Estudos", CriadoEm = DateTime.Now.AddDays(2) },
            new Categoria { CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", Nome = "Descontração", CriadoEm = DateTime.Now.AddDays(3) }
        );

        modelBuilder.Entity<Tarefa>().HasData(
            new Tarefa { TarefaId = "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e", Titulo = "Terminar estudo de um Livro", Descricao = "Fazer um resumo do livro lido", CriadoEm = DateTime.Now.AddDays(7), CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", Status = "Não iniciada" },
            new Tarefa { TarefaId = "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e", Titulo = "Tempo de estudo", Descricao = "Se preparando para as Provas Finais", CriadoEm = DateTime.Now.AddDays(3), CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", Status = "Não iniciada" },
            new Tarefa { TarefaId = "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f", Titulo = "Sair com os Dogs", Descricao = "Se distrair um pouco e levar os cachorros para passear", CriadoEm = DateTime.Now.AddDays(14), CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", Status = "Não iniciada" }
        );
    }
}
