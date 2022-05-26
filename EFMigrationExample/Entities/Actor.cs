
using System;
using System.Collections.Generic;

namespace EFMigrationExample.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }

        public HashSet<Movie> MovieActors { get; set; }
    }
}
