namespace BalatroCalculator.Models.PokerHands;

public sealed class FullHouse : PokerHand
{
    public override string Name { get; protected init; } = "Full House";
    public override int Rank { get; protected init; } = 6;

    public override int ChipsValue { get; protected set; } = 40;
    public override int MultValue { get; protected set; } = 4;

    public override bool IsSecret { get; protected init; } = false;
    public override bool IsMatch(ICollection<PlayingCard> playingCards)
    {
        var groups = playingCards.GroupBy(card => card.Rank).ToList();
        return groups.Count == 2 && groups.Any(group => group.Count() == 3);
    }

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}