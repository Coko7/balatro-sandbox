using BalatroCalculator.Models;
using BalatroCalculator.Models.PokerHands;

namespace BalatroCalculator.Utils;

public static class PokerHandsChecker
{
    private static readonly List<PokerHand> PokerHands =
        [
            new FlushFive(),
            new FlushHouse(),
            new FiveOfAKind(),
            new RoyalFlush(),
            new StraightFlush(),
            new FourOfAKind(),
            new FullHouse(),
            new Flush(),
            new Straight(),
            new ThreeOfAKind(),
            new TwoPair(),
            new Pair(),
            new HighCard()
        ];

    public static PokerHand DeterminePokerHands(ICollection<PlayingCard> playingCards)
    {
        foreach (var pokerHand in PokerHands)
        {
            if (pokerHand.IsMatch(playingCards)) return pokerHand;
        }

        throw new Exception("We should technically never reach this point");
    }
}