namespace BalatroCalculator.PokerHands;

public sealed class StraightFlush : PokerHand
{
    public override string Name { get; protected init; } = "Straight Flush";
    public override int Rank { get; protected init; } = 8;

    public override int ChipsValue { get; protected set; } = 100;
    public override int MultValue { get; protected set; } = 8;

    public override bool IsSecret { get; protected init; } = false;
    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        if (playingCards.Count != 5) return false;
        if (playingCards.GroupBy(card => card.Suit).Count() != 1) return false;

        var sortedPlayingCards = playingCards.OrderBy(card => card.Rank).ToList();

        var previous = sortedPlayingCards.First();
        for (var i = 1; i < sortedPlayingCards.Count; i++)
        {
            var current = sortedPlayingCards.ElementAt(i);

            if (i == 1 && current.Rank == CardRank.Ten && previous.Rank == CardRank.Ace)
            {
                previous = current;
                continue;
            }
            
            if (current.Rank - previous.Rank != 1) return false;
            previous = current;
        }

        return true;
    }

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}