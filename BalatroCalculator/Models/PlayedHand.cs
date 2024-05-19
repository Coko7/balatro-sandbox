namespace BalatroCalculator.Models;

public class PlayedHand
{
    private ICollection<PlayingCard> _playedCards;

    public PlayedHand(ICollection<PlayingCard> playedCards)
    {
        if (playedCards.Count is < 1 or > 5) throw new Exception("Invalid hand size");
        _playedCards = playedCards;
    }
}
