using ClashRoyaleApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashRoyaleApi
{
    public class RoyaleAPI
    {
        #region Private fields
        /// <summary>
        /// Defines endpoints
        /// </summary>
        private static readonly string _BASE_URL = "http://www.clashapi.xyz/api";
        private static readonly string _IMAGES = "http://www.clashapi.xyz/api/images";
        private static readonly string _ARENAS = _BASE_URL + "/arenas/";
        private static readonly string _ARENA_IMAGE = _IMAGES + "/arenas/";
        private static readonly string _CARDS = _BASE_URL + "/cards/";
        private static readonly string _CARD_IMAGE = _IMAGES + "/cards/";
        private static readonly string _CHESTS = _BASE_URL + "/chests/";
        private static readonly string _CHEST_IMAGE = _IMAGES + "/chests/";
        private static readonly string _LEAGUES = _BASE_URL + "/leagues/";
        private static readonly string _LEAGUE_IMAGE = _IMAGES + "/leagues/";
        private static readonly string _PLAYERS = _BASE_URL + "/players/";
        private static readonly string _RANDOM_DECK = _BASE_URL + "/random-deck";
        #endregion

        #region Cards Operations
        /// <summary>
        /// Returns a list of all the cards available
        /// </summary>
        /// <returns>List<Card></returns>
        public static List<Card> GetCards()
        {
            string response = Connections.GetURL(_CARDS).Result;
            List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(response);
            return cards;
        }

        /// <summary>
        /// Returns a single card
        /// </summary>
        /// <param name="id">The id of the card to search</param>
        /// <returns>Card</returns>
        public static Card GetCard(string id)
        {
            string formattedUrl = _CARDS + id;
            string response = Connections.GetURL(formattedUrl).Result;
            return JsonConvert.DeserializeObject<Card>(response);
        }

        /// <summary>
        /// Returns the url of the card image
        /// </summary>
        /// <param name="IdName">Card name</param>
        /// <returns>string</returns>
        public static string GetCardImageURL(string idName)
        {
            return _CARD_IMAGE + idName;
        }
        #endregion

        #region Arenas Operations
        /// <summary>
        /// Returns all the available arenas
        /// </summary>
        /// <returns>List<Arena></returns>
        public static List<Arena> GetArenas()
        {
            string response = Connections.GetURL(_ARENAS).Result;
            return JsonConvert.DeserializeObject<List<Arena>>(response);
        }

        /// <summary>
        /// Returns a single arena
        /// </summary>
        /// <param name="id">The id of the arena</param>
        /// <returns>Arena</returns>
        public static Arena GetArena(string id)
        {
            string response = Connections.GetURL(_ARENAS + id).Result;
            return JsonConvert.DeserializeObject<Arena>(response);
        }

        /// <summary>
        /// Returns the url of the arena image
        /// </summary>
        /// <param name="IdName">The name of the arena</param>
        /// <returns>string</returns>
        public static string GetArenaImageURL(string idName)
        {
            return _ARENA_IMAGE + idName;
        }
        #endregion

        #region Chests Operations
        /// <summary>
        /// Returns all the chests
        /// </summary>
        /// <returns>List<Chest></returns>
        public static List<Chest> GetChests()
        {
            string response = Connections.GetURL(_CHESTS).Result;
            return JsonConvert.DeserializeObject<List<Chest>>(response);
        }
        
        /// <summary>
        /// Returns a chest
        /// </summary>
        /// <param name="id">The id or name of the chest</param>
        /// <returns>Chest</returns>
        public static Chest GetChest(string id)
        {
            string response = Connections.GetURL(_CHESTS + id).Result;
            return JsonConvert.DeserializeObject<Chest>(response);
        }

        /// <summary>
        /// Gets the chest image url
        /// </summary>
        /// <param name="idName">Name of the chest</param>
        /// <returns>string</returns>
        public static string GetChestImageURL(string idName)
        {
            return _CHEST_IMAGE + idName;
        }
        #endregion

        #region Leagues Operations
        /// <summary>
        /// Returns all the available leagues
        /// </summary>
        /// <returns>List<League></returns>
        public static List<League> GetLeagues()
        {
            string response = Connections.GetURL(_LEAGUES).Result;
            return JsonConvert.DeserializeObject<List<League>>(response);
        }

        /// <summary>
        /// Returns one league
        /// </summary>
        /// <param name="id">The id of the league</param>
        /// <returns></returns>
        public static League GetLeague(string id)
        {
            string response = Connections.GetURL(_LEAGUES + id).Result;
            return JsonConvert.DeserializeObject<League>(response);
        }

        /// <summary>
        /// Returns the url for the league
        /// </summary>
        /// <param name="idName">The league to search for</param>
        /// <returns>string</returns>
        public static string GetLeagueImageURL(string idName)
        {
            return _LEAGUE_IMAGE + idName;
        }

        #endregion

        #region Players Operations
        /// <summary>
        /// Returns all player levels info
        /// </summary>
        /// <returns>List<Player></returns>
        public static List<Player> GetPlayers()
        {
            string response = Connections.GetURL(_PLAYERS).Result;
            return JsonConvert.DeserializeObject<List<Player>>(response);
        }

        /// <summary>
        /// Returns info about a player level
        /// </summary>
        /// <param name="id">The id of the player level</param>
        /// <returns>Player</returns>
        public static Player GetPlayer(string id)
        {
            string response = Connections.GetURL(_PLAYERS + id).Result;
            return JsonConvert.DeserializeObject<Player>(response);
        }
        #endregion

        #region Random Decks Operations
        /// <summary>
        /// Returns a random deck, 8 cards.
        /// </summary>
        /// <returns>List<Card></returns>
        public static List<Card> GetRandomDeck()
        {
            string response = Connections.GetURL(_RANDOM_DECK).Result;
            return JsonConvert.DeserializeObject<List<Card>>(response);
        }
        #endregion
    }
}
















