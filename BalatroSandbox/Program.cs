// See https://aka.ms/new-console-template for more information

using BalatroCalculator.Models;
using BalatroCalculator.Utils;

var playedCards = new List<PlayingCard>
{
    new(CardRank.Ace, CardSuit.Club),
    new(CardRank.Two, CardSuit.Spade),
    new(CardRank.Three, CardSuit.Club),
    new(CardRank.Four, CardSuit.Diamond),
    new(CardRank.King, CardSuit.Spade),
};

var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
Console.WriteLine(pokerHandMatched);
