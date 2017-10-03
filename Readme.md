# Clash Royale Api

Get all info about clash royale cards, loot, leagues and player level's.

This is a wrapper for the awesome NodeJS Clash Royale api made by [Martin Carrera](https://github.com/martincarrera/clash-royale-api).

#### Motivation
The need to use this library in any dotnet core application.

#### Usage

Install using your favorite package manager:

- `PM> Install-Package ClashRoyaleApi -Version 1.0.0`
- `$ dotnet add package ClashRoyaleApi --version 1.0.0`
- `$ paket add ClashRoyaleApi --version 1.0.0`

**Available models**:

`Arena`
`Card`
`Chest`
`League`
`Player`

**Available methods:**

```csharp
// Required namespace
using ClashRoyaleApi

// Returns all cards
RoyaleAPI.GetCards();

// Returns a single card
RoyaleAPI.GetCard(id); 

// Returns the card image url
RoyaleAPI.GetCardImageURL(idName) ;

// Returns all arenas
RoyaleAPI.GetArenas();

// Returns a single arena
RoyaleAPI.GetArena(id); 

// Returns the arena image url
RoyaleAPI.GetArenaImageURL(idName);

// Returns all chests
RoyaleAPI.GetChests();

// Returns a single chest
RoyaleAPI.GetChest(id);

// Returns the chest image url
RoyaleAPI.GetChestURL(idName);

// Returns all leagues
RoyaleAPI.GetLeagues();

// Returns a single league
RoyaleAPI.GetLeague(id);

// Returns the league image
RoyaleAPI.GetLeagueImageURL(idName);

// Returns all info about players
RoyaleAPI.GetPlayers();

// Returns info about a single player level
RoyaleAPI.GetPlayer(id);

// Returns a random deck
RoyaleAPI.GetRandomDeck();

// EXAMPLES

// Getting all the cards
List<Card> cards = RoyaleAPI.GetCards();
foreach (Card card in cards)
{
    Console.WriteLine(card.Name);
}

// Getting a random deck
List<Card> randomDeck = RoyaleAPI.GetRandomDeck();
```

#### TODO
- Better error handling.
- Improve documentation.
- General refactor.
- ~~Publish package.~~ - Available @ [Nuget](https://www.nuget.org/packages/ClashRoyaleApi/)


#### License
[MIT - André Varandas](LICENSE.txt)

#### Important Notice
This content is not affiliated with, endorsed, sponsored, or specifically approved by Supercell and Supercell is not responsible for it. For more information see Supercell's Fan Content Policy: [www.supercell.com/fan-content-policy](www.supercell.com/fan-content-policy).
