using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoEperts.Shared
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public int addressId { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        IList<Product> Products { get; set; }
    }
}
