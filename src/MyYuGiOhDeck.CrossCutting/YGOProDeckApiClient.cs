using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Domain.ValueObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.CrossCutting
{
    public class YGOProDeckApiClient : IYGOProDeckApiClient
    {
        public async Task<IList<SpellTrapCard>> GetAllSpellCardsAsync()
        {
            using (var response = await ApiHelper.ApiClient.GetAsync("?type=spell%20card"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var cards = JsonConvert.DeserializeObject<IList<SpellTrapCard>>(jsonString.Substring(1, jsonString.Length - 2));
                    if (cards == null)
                    {
                        return default;
                    }
                    return cards;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
