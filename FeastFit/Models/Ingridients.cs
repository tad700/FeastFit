using System.ComponentModel.DataAnnotations;

namespace FitFeast.Models
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        [Required]
        public string IngredientName { get; set; } = null!;
        public string Aisle { get; set; } = null!;
        public int Amount { get; set; }
        public string Units { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public byte Servings { get; set; }
        public byte ReadyIn { get; set; }

        public List<IngredientRecipe> IngredientRecipes { get; set; } = null!;
    }
}