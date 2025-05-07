namespace Pokemon_reviewApp.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; } // Navigation property to the Pokemon entity
        public Category Category { get; set; } // Navigation property to the Category entity
    }
}
