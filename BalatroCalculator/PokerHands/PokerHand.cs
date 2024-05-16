namespace BalatroCalculator.PokerHands;

public abstract class PokerHand : IComparable<PokerHand>
{
    public abstract string Name { get; protected init; }
    public abstract int Rank { get; protected init; }

    public abstract int ChipsValue { get; protected set; }
    public abstract int MultValue { get; protected set; }
    public abstract bool IsSecret { get; protected init; }

    public int Level { get; private set; } = 0;

    public abstract bool IsMatch(ICollection<PlayingCard> playingCards);

    public abstract void LevelUp();
    
    public int CompareTo(PokerHand? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        return Rank.CompareTo(other.Rank);
    }

    public override string ToString() => $"{Rank}. {Name}: {ChipsValue} * {MultValue} [lvl. {Level}]";
}