namespace BalatroCalculator.PokerHands;

public sealed class HighCard : PokerHand
{
    public override string Name { get; protected init; } = "High Card";
    public override int Rank { get; protected init; } = 0;
    
    public override int ChipsValue { get; protected set; } = 5;
    public override int MultValue { get; protected set; } = 1;

    public override bool IsSecret { get; protected init; } = false;

    public override bool IsMatch(ICollection<PlayingCard> playingCards) => true;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}