namespace BalatroCalculator.Models.PokerHands;

public sealed class TwoPair : PokerHand
{
    public override string Name { get; protected init; } = "Two Pair";
    public override int Rank { get; protected init; } = 2;

    public override int ChipsValue { get; protected set; } = 20;
    public override int MultValue { get; protected set; } = 2;

    public override bool IsSecret { get; protected init; } = false;
    
    public override bool IsMatch(ICollection<PlayingCard> playingCards) =>
        playingCards
            .GroupBy(card => card.Rank)
            .Count() == playingCards.Count - 2;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}