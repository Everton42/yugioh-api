namespace MyYuGiOhDeck.Domain.Entities
{
    public class MonsterCard : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Race { get; set; }
        public string Archetype { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        public string Setcode { get; set; }
        public string SetTag { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Level { get; set; }
        public string Attribute { get; set; }
    }
}
