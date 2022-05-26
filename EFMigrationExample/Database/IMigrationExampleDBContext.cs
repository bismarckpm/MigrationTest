using EFMigrationExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFMigrationExample.Database
{
    public interface IMigrationExampleDBContext
    {
        DbContext DbContext
        {
            get;
        }

        DbSet<Genre> Genres
        {
            get; set;
        }
    }
}
