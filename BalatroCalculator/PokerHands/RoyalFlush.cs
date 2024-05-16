namespace BalatroCalculator.PokerHands;

public sealed class RoyalFlush : PokerHand
{
    public override string Name { get; protected init; } = "Royal Flush";
    public override int Rank { get; protected init; } = 9;

    public override int ChipsValue { get; protected set; } = 100;
    public override int MultValue { get; protected set; } = 100;

    public override bool IsSecret { get; protected init; } = false;
    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        var sortedPlayingCards = playingCards.OrderBy(card => card.Rank).ToList();

        // Make sure all cards share the same suit.
        if (sortedPlayingCards.GroupBy(card => card.Suit).Count() != 1) return false;
        
        // There is only one possible sequence for a Royal Flush so a manuel check works.
        if (sortedPlayingCards.ElementAt(0).Rank != CardRank.Ace) return false;
        if (sortedPlayingCards.ElementAt(1).Rank != CardRank.Ten) return false;
        if (sortedPlayingCards.ElementAt(2).Rank != CardRank.Jack) return false;
        if (sortedPlayingCards.ElementAt(3).Rank != CardRank.Queen) return false;
        if (sortedPlayingCards.ElementAt(4).Rank != CardRank.King) return false;

        return true;
    }

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}