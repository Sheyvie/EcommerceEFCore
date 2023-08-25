using Ecommerce;
using Ecommerce.Data;

ApplicationDbContext context = new ApplicationDbContext();

context.Database.EnsureCreated();
//Queries queries = new Queries();
//queries.AddNewUser();
//queries.fetchAllUsers();