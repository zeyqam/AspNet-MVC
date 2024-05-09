using AspIntro_MVC.Models;
using AspIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()

        {
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
                Users=GetAllUsers()

                
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
    }
}
