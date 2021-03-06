
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusStationTickets.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
