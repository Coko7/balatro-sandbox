namespace BalatroCalculator.PokerHands;

public sealed class FlushHouse : PokerHand
{
    public override string Name { get; protected init; } = "Flush House";
    public override int Rank { get; protected init; } = 11;

    public override int ChipsValue { get; protected set; } = 140;
    public override int MultValue { get; protected set; } = 14;

    public override bool IsSecret { get; protected init; } = true;
    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        if (playingCards.GroupBy(card => card.Suit).Count() != 1) return false;
        
        var groups = playingCards.GroupBy(card => card.Rank).ToList();
        return groups.Count == 2 && groups.Any(group => group.Count() == 3);
    }

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}