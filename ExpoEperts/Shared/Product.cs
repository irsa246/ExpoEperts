using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoEperts.Shared
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public int sellerId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double? price { get; set; }
        public int category { get; set; }
        public string Image { get; set; }
        public int userId { get; set; }

        public User user { get; set; }
        
    }
}
