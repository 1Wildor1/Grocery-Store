using GroceryStore.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ProductID { get; set; }
        public Grade? Grade { get; set; }

        public virtual ProductDTO ProductDTO { get; set; }
    }
}