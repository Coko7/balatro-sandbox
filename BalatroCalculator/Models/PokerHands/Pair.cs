namespace BalatroCalculator.Models.PokerHands;

public sealed class Pair : PokerHand
{
    public override string Name { get; protected init; } = "Pair";
    public override int Rank { get; protected init; } = 1;

    public override int ChipsValue { get; protected set; } = 10;
    public override int MultValue { get; protected set; } = 2;

    public override bool IsSecret { get; protected init; } = false;

    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards
            .GroupBy(card => card.Rank)
            .Count() == playingCards.Count - 1;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}