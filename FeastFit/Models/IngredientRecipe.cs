using System.ComponentModel.DataAnnotations;

namespace FitFeast.Models
{
    public class IngredientRecipe
    {
        [Key]
        public long IngredientId { get; set; }
        public long RecipeId { get; set; }

        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
    }
}
