using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models.Products
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string NameProd { get; set; }
        public decimal Price { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}