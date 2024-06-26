using BalatroCalculator.Models;
using BalatroCalculator.Models.PokerHands;
using BalatroCalculator.Utils;

namespace BalatroCalculator.Tests;

public class PokerHandsMatchLogicTests
{
    [Fact]
    public void Test_Is_HighCard()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Ace, CardSuit.Club),
            new(CardRank.Two, CardSuit.Spade),
            new(CardRank.Three, CardSuit.Club),
            new(CardRank.Four, CardSuit.Diamond),
            new(CardRank.King, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<HighCard>(pokerHandMatched);
    }

    [Fact]
    public void Test_Is_Pair()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Two, CardSuit.Club),
            new(CardRank.Two, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<Pair>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_TwoPair()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Two, CardSuit.Club),
            new(CardRank.Two, CardSuit.Spade),
            new(CardRank.Five, CardSuit.Club),
            new(CardRank.Ten, CardSuit.Heart),
            new(CardRank.Five, CardSuit.Diamond),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<TwoPair>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_ThreeOfAKind()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Two, CardSuit.Club),
            new(CardRank.Eight, CardSuit.Spade),
            new(CardRank.King, CardSuit.Club),
            new(CardRank.King, CardSuit.Diamond),
            new(CardRank.King, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<ThreeOfAKind>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_Straight()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Eight, CardSuit.Club),
            new(CardRank.Nine, CardSuit.Heart),
            new(CardRank.Ten, CardSuit.Club),
            new(CardRank.Jack, CardSuit.Diamond),
            new(CardRank.Queen, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<Straight>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_Straight_TopAce()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Ten, CardSuit.Club),
            new(CardRank.Jack, CardSuit.Heart),
            new(CardRank.Queen, CardSuit.Club),
            new(CardRank.King, CardSuit.Diamond),
            new(CardRank.Ace, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<Straight>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_Flush()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Eight, CardSuit.Club),
            new(CardRank.Nine, CardSuit.Club),
            new(CardRank.Jack, CardSuit.Club),
            new(CardRank.Jack, CardSuit.Club),
            new(CardRank.Queen, CardSuit.Club),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<Flush>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_FullHouse()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Eight, CardSuit.Club),
            new(CardRank.Ace, CardSuit.Heart),
            new(CardRank.Ace, CardSuit.Club),
            new(CardRank.Eight, CardSuit.Spade),
            new(CardRank.Ace, CardSuit.Club),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<FullHouse>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_FourOfAKind()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Seven, CardSuit.Club),
            new(CardRank.Seven, CardSuit.Heart),
            new(CardRank.Seven, CardSuit.Club),
            new(CardRank.Seven, CardSuit.Spade),
            new(CardRank.Eight, CardSuit.Club),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<FourOfAKind>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_StraightFlush()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Eight, CardSuit.Heart),
            new(CardRank.Nine, CardSuit.Heart),
            new(CardRank.Ten, CardSuit.Heart),
            new(CardRank.Jack, CardSuit.Heart),
            new(CardRank.Queen, CardSuit.Heart),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<StraightFlush>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_StraightFlush_LowAce()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Ace, CardSuit.Spade),
            new(CardRank.Two, CardSuit.Spade),
            new(CardRank.Three, CardSuit.Spade),
            new(CardRank.Four, CardSuit.Spade),
            new(CardRank.Five, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<StraightFlush>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_RoyalFlush()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Ten, CardSuit.Heart),
            new(CardRank.King, CardSuit.Heart),
            new(CardRank.Jack, CardSuit.Heart),
            new(CardRank.Ace, CardSuit.Heart),
            new(CardRank.Queen, CardSuit.Heart),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<RoyalFlush>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_FiveOfAKind()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Ten, CardSuit.Club),
            new(CardRank.Ten, CardSuit.Diamond),
            new(CardRank.Ten, CardSuit.Heart),
            new(CardRank.Ten, CardSuit.Heart),
            new(CardRank.Ten, CardSuit.Spade),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<FiveOfAKind>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_FlushHouse()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Seven, CardSuit.Diamond),
            new(CardRank.Seven, CardSuit.Diamond),
            new(CardRank.Seven, CardSuit.Diamond),
            new(CardRank.Queen, CardSuit.Diamond),
            new(CardRank.Queen, CardSuit.Diamond),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<FlushHouse>(pokerHandMatched);
    }
    
    [Fact]
    public void Test_Is_FlushFive()
    {
        var playedCards = new List<PlayingCard>
        {
            new(CardRank.Two, CardSuit.Diamond),
            new(CardRank.Two, CardSuit.Diamond),
            new(CardRank.Two, CardSuit.Diamond),
            new(CardRank.Two, CardSuit.Diamond),
            new(CardRank.Two, CardSuit.Diamond),
        };

        var pokerHandMatched = PokerHandsChecker.DeterminePokerHands(playedCards);
        Assert.IsType<FlushFive>(pokerHandMatched);
    }
}