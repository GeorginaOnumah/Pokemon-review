﻿namespace Pokemon_reviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; } //many to many relationship
    }
}
