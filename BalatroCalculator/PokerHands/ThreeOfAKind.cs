namespace BalatroCalculator.PokerHands;

public sealed class ThreeOfAKind : PokerHand
{
    public override string Name { get; protected init; } = "Three of a Kind";
    public override int Rank { get; protected init; } = 3;
    
    public override int ChipsValue { get; protected set; } = 30;
    public override int MultValue { get; protected set; } = 3;

    public override bool IsSecret { get; protected init; } = false;
    
    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards
            .GroupBy(card => card.Rank)
            .Any(group => group.Count() == 3);

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}