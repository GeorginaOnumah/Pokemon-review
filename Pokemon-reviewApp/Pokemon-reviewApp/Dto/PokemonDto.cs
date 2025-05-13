namespace Pokemon_reviewApp.Dto
{
    public class PokemonDto // to limit the amount of data sent to the client vice versa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
