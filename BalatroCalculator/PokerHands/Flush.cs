namespace BalatroCalculator.PokerHands;

public sealed class Flush : PokerHand
{
    public override string Name { get; protected init; } = "Flush";
    public override int Rank { get; protected init; } = 5;

    public override int ChipsValue { get; protected set; } = 35;
    public override int MultValue { get; protected set; } = 4;

    public override bool IsSecret { get; protected init; } = false;
    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards.Count == 5 && playingCards.GroupBy(card => card.Suit).Count() == 1;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}