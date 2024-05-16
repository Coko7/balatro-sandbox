namespace BalatroCalculator;

public enum CardRank
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
}

public enum CardSuit
{
    Spade = 0,
    Heart = 1,
    Club = 2,
    Diamond = 3
}

public enum CardEnhancement { Bonus, Mult, Wild, Glass, Steel, Stone, Gold, Lucky }

public enum CardEdition { Base, Foil, Holographic, Polychrome, Negative }

public enum CardSeal { Gold, Red, Blue, Purple }

public class PlayingCard(CardRank rank, CardSuit suit) : IComparable<PlayingCard>
{
    public CardRank Rank { get; } = rank;
    public CardSuit Suit { get; } = suit;

    public CardEdition Edition { get; set; } = CardEdition.Base;
    public CardEnhancement? Enhancement { get; set; }
    public CardSeal? Seal { get; set; }

    public bool IsFaceCard => (int)Rank > 10;
    public bool IsEvenCard => !IsFaceCard && (int)Rank % 2 == 0;
    public bool IsOddCard => !IsFaceCard && (int)Rank % 2 != 0;

    public string DisplayValue
    {
        get
        {
            if ((int)Rank == 1 || (int)Rank > 10) return Rank.ToString();
            
            return ((int)Rank).ToString();
        }
    }

    public int BaseChipsValue =>
        (int)Rank switch
        {
            1 => 11,
            > 10 => 10,
            _ => (int)Rank
        };

    public int CompareTo(PlayingCard? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        return Rank.CompareTo(other.Rank);
    }

    public override string ToString() => $"{DisplayValue}";
}