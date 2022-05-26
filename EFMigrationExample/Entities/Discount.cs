using System;


namespace EFMigrationExample.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Percentage { get; set; }
    }
}
