using Newtonsoft.Json;

namespace MyYuGiOhDeck.Domain.Entities
{
    public class SpellTrapCard
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        public string Race { get; set; }
        public string Archetype { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("image_url_small")]
        public string ImageUrlSmall { get; set; }
        public string Setcode { get; set; }
        [JsonProperty("set_tag")]
        public string SetTag { get; set; }
    }
}
