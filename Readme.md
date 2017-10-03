# Clash Royale Api

Get all info about clash royale cards, loot, leagues and player levels.

This is a wrapper for the awesome NodeJS Clash Royale api made by [Martin Carrera](https://github.com/martincarrera/clash-royale-api).

#### Motivation
The need to use this library in any dotnet core application.

#### Usage

Install using your favorite package manager:

- `PM> Install-Package ClashRoyaleApi -Version 1.0.0`
- `$ dotnet add package ClashRoyaleApi --version 1.0.0`
- `$ paket add ClashRoyaleApi --version 1.0.0`

**Models**:

`Arena`
`Card`
`Chest`
`League`
`Player`

**Available methods:**

*Requirements*
```csharp
using ClashRoyaleApi;
using ClashRoyaleApi.Models;
```

*Cards:*
```csharp
// Returns all cards
List<Card> cards = RoyaleAPI.GetCards();

// Returns a single card - Id name or id
Card card = RoyaleAPI.GetCard("fireball");

// Returns the card image url
string imageUrl = RoyaleAPI.GetCardImageURL(idName);
```

*Arenas:*
```csharp
// Returns all arenas
List<Arena> arenas = RoyaleAPI.GetArenas();

// Returns a single arena - id or idname
Arena arena = RoyaleAPI.GetArena(id);

// Returns the arena image url
string arena url = RoyaleAPI.GetArenaImageURL(idName);
```

*Chests:*
```csharp
// Returns all chests
List<Chest> chests = RoyaleAPI.GetChests();

// Returns a single chest
Chest chest = RoyaleAPI.GetChest(id);

// Returns the chest image url
string chestImageUrl = RoyaleAPI.GetChestURL(idName);
```

*Leagues:*
```csharp
// Returns all leagues
List<League> leagues = RoyaleAPI.GetLeagues();

// Returns a single league
League league = RoyaleAPI.GetLeague(id);

// Returns the league image
string leagueImageUrl = RoyaleAPI.GetLeagueImageURL(idName);
```

*Player info:*
```csharp
// Returns all info about players
List<Players> players = RoyaleAPI.GetPlayers();

// Returns info about a single player level
Player player = RoyaleAPI.GetPlayer(id);
```


*And more examples:*

```csharp
// Getting all the cards
List<Card> cards = RoyaleAPI.GetCards();
foreach (Card card in cards)
{
    Console.WriteLine(card.Name);
}
````

```csharp
// Getting a random deck
List<Card> randomDeck = RoyaleAPI.GetRandomDeck();
```

Explore model properties:

![](./extra/example1.png);

#### TODO
- Better error handling.
- Improve documentation.
- General refactor.
- ~~Publish package.~~ - Available @ [Nuget](https://www.nuget.org/packages/ClashRoyaleApi/)


#### License
[MIT - André Varandas](LICENSE.txt)

#### Important Notice
This content is not affiliated with, endorsed, sponsored, or specifically approved by Supercell and Supercell is not responsible for it. For more information see Supercell's Fan Content Policy: [www.supercell.com/fan-content-policy](www.supercell.com/fan-content-policy).
