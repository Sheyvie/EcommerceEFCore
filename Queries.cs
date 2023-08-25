using Ecommerce.Data;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{

   
    public  class Queries
    {
        private ApplicationDbContext context = new ApplicationDbContext();


        public void AddNewUser()
        {
            var newUser = new User()
            {
                FirstName="Left",
                LastName="Conner",
                Email="leftconner@gmail.com"


            };

            context.Users.Add(newUser);
            context.SaveChanges();

        }
        public async Task fetchAllUsers()
        {
            var users = context.Users.ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.UserId}-- {user.FirstName}-- {user.LastName} --{user.Email}");
            }
        }

    }
}
