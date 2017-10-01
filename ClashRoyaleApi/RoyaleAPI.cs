using System;
using System.Threading.Tasks;

namespace ClashRoyaleApi
{
    public class RoyaleAPI
    {

        #region Private fields
        private static readonly string _BASE_URL = "http://www.clashapi.xyz/api";
        private static readonly string _ARENAS = _BASE_URL + "/arenas";
        private static readonly string _CARDS = _BASE_URL + "/cards";
        private static readonly string _CHESTS = _BASE_URL + "/chests";
        private static readonly string _LEAGUES = _BASE_URL + "/leagues";
        private static readonly string _PLAYERS = _BASE_URL + "/players";
        private static readonly string _RANDOM_DECK = _BASE_URL + "/random-deck";
        #endregion

        #region Cards Operations
        //`RoyaleAPI.GetCards()` // Returns all cards
        public static Task GetCards()
        {
            Task<string> response = Connections.GetURL(_CARDS);
            return response;
        }


        //`RoyaleAPI.GetCard(id)` // Returns a single card

        //`RoyaleAPI.GetCardImage(id)` // Returns the card image
        #endregion

        #region Arenas Operations
        //`RoyaleAPI.GetArenas()` // Returns all arenas

        //`RoyaleAPI.GetArena(id)` // Returns a single arena

        //`RoyaleAPI.GetArenaImage(id)` // Returns the arena image
        #endregion

        #region Chests Operations
        //`RoyaleAPI.GetChests()` // Returns all chests

        //`RoyaleAPI.GetChest(id)` // Returns a single chest

        //`RoyaleAPI.GetChest(id)` // Returns the chest image
        #endregion

        #region Leagues Operations
        //`RoyaleAPI.GetLeagues()` // Returns all leagues

        //`RoyaleAPI.GetLeague(id)` // Returns a single league

        //`RoyaleAPI.GetLeague(id)` // Returns the league image
        #endregion

        #region Players Operations
        //`RoyaleAPI.GetPlayers()` // Returns all info about players

        //`RoyaleAPI.GetPlayer(id)` // Returns info about a single player level
        #endregion

        #region Random Decks Operations
        //`RoyaleAPI.GetRandomDeck()` // Returns a random deck
        #endregion
    }
}
















