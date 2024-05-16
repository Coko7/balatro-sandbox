namespace BalatroCalculator.PokerHands;

public sealed class FourOfAKind : PokerHand
{
    public override string Name { get; protected init; } = "Four of a Kind";
    public override int Rank { get; protected init; } = 7;

    public override int ChipsValue { get; protected set; } = 60;
    public override int MultValue { get; protected set; } = 7;

    public override bool IsSecret { get; protected init; } = false;
    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards
            .GroupBy(card => card.Rank)
            .Any(group => group.Count() == 4);

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}