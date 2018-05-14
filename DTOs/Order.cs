using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace slnExamen3.DTOs
{
    class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Double TotalCost { get; set; }

        public int ClientId { get; set; }
    }
}
