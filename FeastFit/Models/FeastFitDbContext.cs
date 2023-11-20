using FitFeast.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace FeastFit.Models
{
    public class FeastFitDbContext : DbContext
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Todor\\Documents\\FitFeastDB.mdf;Integrated Security=True;Connect Timeout=30";

        public DbSet<User> Users { get; set; }
        public DbSet<IngredientRecipe> ingredientRecipes { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<Recipe> recipes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connString);
        }

    }

}
