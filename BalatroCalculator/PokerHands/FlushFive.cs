namespace BalatroCalculator.PokerHands;

public sealed class FlushFive : PokerHand
{
    public override string Name { get; protected init; } = "Flush Five";
    public override int Rank { get; protected init; } = 12;
    public override int ChipsValue { get; protected set; } = 160;
    public override int MultValue { get; protected set; } = 16;

    public override bool IsSecret { get; protected init; } = true;
    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        if (playingCards.Count != 5) return false;
        
        if (playingCards.GroupBy(card => card.Rank).Count() != 1) return false;
        if (playingCards.GroupBy(card => card.Suit).Count() != 1) return false;

        return true;
    }

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}