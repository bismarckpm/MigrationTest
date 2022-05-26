

using System.Collections.Generic;

namespace EFMigrationExample.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public HashSet<Genre> Genres { get; set; }

        public HashSet<MovieActor> MovieActors { get; set; }
    }
}
