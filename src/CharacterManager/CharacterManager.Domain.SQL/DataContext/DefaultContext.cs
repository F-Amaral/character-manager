using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Domain.SQL.DataContext
{
    public class DefaultContext : DbContext
    {
        public DefaultContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
