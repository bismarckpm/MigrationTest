
using System.Collections.Generic;

namespace EFMigrationExample.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        // public HashSet<Movie> Movies { get; set; }
    }
}
