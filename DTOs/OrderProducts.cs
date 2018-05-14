using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace slnExamen3.DTOs
{
    class OrderProducts
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public Double total { get; set; }
    }
}
