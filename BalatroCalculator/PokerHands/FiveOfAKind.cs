namespace BalatroCalculator.PokerHands;

public sealed class FiveOfAKind : PokerHand
{
    public override string Name { get; protected init; } = "Five of a Kind";
    public override int Rank { get; protected init; } = 10;

    public override int ChipsValue { get; protected set; } = 120;
    public override int MultValue { get; protected set; } = 12;

    public override bool IsSecret { get; protected init; } = true;
    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards.Count == 5 && playingCards.GroupBy(card => card.Rank).Count() == 1;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}