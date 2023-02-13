using GroceryStore.Models;
using GroceryStore.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStore.Dal
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var product = new List<ProductDTO>
            {
            new ProductDTO{NameProd="Апельсин",Price=120,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Яблоко",Price=40,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Ананас",Price=200,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Банан",Price=50,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Киви",Price=70,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Помело",Price=140,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Мандарин",Price=110,EnrollmentDate=DateTime.Parse("2023-02-12")},
            new ProductDTO{NameProd="Лимон",Price=45,EnrollmentDate=DateTime.Parse("2023-02-12")}
            };
            product.ForEach(s => context.ProductDTO.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{ProductID=1,Grade=Grade.A},
            new Enrollment{ProductID=1,Grade=Grade.C},
            new Enrollment{ProductID=1,Grade=Grade.B},
            new Enrollment{ProductID=2,Grade=Grade.B},
            new Enrollment{ProductID=2,Grade=Grade.F},
            new Enrollment{ProductID=2,Grade=Grade.F},
            new Enrollment{ProductID=3},
            new Enrollment{ProductID=4},
            new Enrollment{ProductID=4,Grade=Grade.F},
            new Enrollment{ProductID=5,Grade=Grade.C},
            new Enrollment{ProductID=6},
            new Enrollment{ProductID=7,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}