using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class AppDbContext : DbContext //A classe "AppDbcontext ele herda do dbContext que vem do EntityFramework
    {
        public AppDbContext(DbContextOptions options) : base(options) { } //configuração do banco de dados
        public DbSet<Pessoa> FirstAPI { get; set; } //DbSet herda da classe Pessoa para criar a tabela |FirstAPI é o nome do banco de dados
    }
}
