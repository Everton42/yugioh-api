namespace MyYuGiOhDeck.Domain.Entities
{
    public class MonsterCard : Card
    {
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Level { get; set; }
        public string Attribute { get; set; }
    }
}
