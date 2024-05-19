namespace BalatroCalculator.Models.PokerHands;

public sealed class Straight : PokerHand
{
    public override string Name { get; protected init; } = "Straight";
    public override int Rank { get; protected init; } = 4;

    public override int ChipsValue { get; protected set; } = 30;
    public override int MultValue { get; protected set; } = 4;

    public override bool IsSecret { get; protected init; } = false;

    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        if (playingCards.Count != 5) return false;

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