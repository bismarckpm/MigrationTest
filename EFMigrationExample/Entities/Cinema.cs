using System;
using System.Collections.Generic;

namespace EFMigrationExample.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public Discount Discount { get; set; }

        public HashSet<Room> Rooms { get; set; }


        /* public ICollection<Room> Rooms
         {
             get; set;
         }*/

        /*public List<Room> Rooms
        {
            get; set;
        }*/
    }
}
