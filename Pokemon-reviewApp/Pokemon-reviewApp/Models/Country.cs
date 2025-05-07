namespace Pokemon_reviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; } //one-to-many relationship or many to many relationship
    }
}
