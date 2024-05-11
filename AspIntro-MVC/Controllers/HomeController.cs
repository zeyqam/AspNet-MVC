using AspIntro_MVC.Models;
using AspIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class HomeController:Controller

    {
        private List<Employee> _employees;
        private List<Product> _products;
        public HomeController()
        {
            _employees = new List<Employee>()
            {
                  new Employee
                {
                    Name="Zeyqem",Surname="Ashirov",Email="ziko@gmail.com",Age=39,Phone="6453635"
                },
                new  Employee
                {
                    Name="Cavid",Surname="Bashirov",Email="cavid@gmail.com",Age=30,Phone="1233456"
                }
            };
            _products = new List<Product>()
            {

                new Product
                {
                    Name="Apple",Price=599.99m,Color="Black"
                },
                new Product
                {
                    Name="Samsung",Price=299.99m,Color="White"
                }
            };
        }
        public IActionResult Index()

        {
            var studentsOrderByAge=GetAllEmployeesOrderByAge();
            var productsCount=GetProductsCount();
            
            string text = "Welcome";
            int ageOfAykhan = 23;
            List<string> students = new()
           {"Emirastan","Fexriyye","Elmir","Ilqar","Nurlan"

    };
            HomeVM model = new HomeVM()
            {
                Text = text,
                Students = students,
                AgeOfAykhan = ageOfAykhan,
                Users=GetAllUsers(),
                Employees=studentsOrderByAge,
                Products=_products,
                ProductsCount=productsCount,
                

                
            };
            return View(model);
            
        }

        private List<User> GetAllUsers()
        {
            return new List<User>()
            {
                new User {
                    Id = 1,
                    Age = 23,
                },
                new User
                {
                    Id = 2,
                    Age = 25,
                }
            };
        }

        private List <Employee> GetAllEmployees()
        {
            return _employees.ToList();
        }
        private List<Product> GetAllProducts()
        {
            return _products.ToList();
        }
        private List<Employee> GetAllEmployeesOrderByAge()
        {
            return _employees.OrderBy(m => m.Age).ToList();
        }

        private int GetProductsCount()
        {
            return _products.Count;
        }
    }
}
