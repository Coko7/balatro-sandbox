using BalatroCalculator.PokerHands;

namespace BalatroCalculator.Tests;

public class PokerHandsValuesTests
{
    [Fact]
    public void Test_HighCard_Ok()
    {
        var pokerHand = new HighCard();
        
        Assert.Equal(5, pokerHand.ChipsValue);
        Assert.Equal(1, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_Pair_Ok()
    {
        var pokerHand = new Pair();
        
        Assert.Equal(10, pokerHand.ChipsValue);
        Assert.Equal(2, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_ThreeOfAKind_Ok()
    {
        var pokerHand = new ThreeOfAKind();
        
        Assert.Equal(30, pokerHand.ChipsValue);
        Assert.Equal(3, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_Straight_Ok()
    {
        var pokerHand = new Straight();
        
        Assert.Equal(30, pokerHand.ChipsValue);
        Assert.Equal(4, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_Flush_Ok()
    {
        var pokerHand = new Flush();
        
        Assert.Equal(35, pokerHand.ChipsValue);
        Assert.Equal(4, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_FullHouse_Ok()
    {
        var pokerHand = new FullHouse();
        
        Assert.Equal(40, pokerHand.ChipsValue);
        Assert.Equal(4, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_FourOfAKind_Ok()
    {
        var pokerHand = new FourOfAKind();
        
        Assert.Equal(60, pokerHand.ChipsValue);
        Assert.Equal(7, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_StraightFlush_Ok()
    {
        var pokerHand = new StraightFlush();
        
        Assert.Equal(100, pokerHand.ChipsValue);
        Assert.Equal(8, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_RoyalFlush_Ok()
    {
        var pokerHand = new RoyalFlush();
        
        Assert.Equal(100, pokerHand.ChipsValue);
        Assert.Equal(8, pokerHand.MultValue);
        Assert.False(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_FiveOfAKind_Ok()
    {
        var pokerHand = new FiveOfAKind();
        
        Assert.Equal(120, pokerHand.ChipsValue);
        Assert.Equal(12, pokerHand.MultValue);
        Assert.True(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_FlushHouse_Ok()
    {
        var pokerHand = new FlushHouse();
        
        Assert.Equal(140, pokerHand.ChipsValue);
        Assert.Equal(14, pokerHand.MultValue);
        Assert.True(pokerHand.IsSecret);
    }
    
    [Fact]
    public void Test_FlushFive_Ok()
    {
        var pokerHand = new FlushFive();
        
        Assert.Equal(160, pokerHand.ChipsValue);
        Assert.Equal(16, pokerHand.MultValue);
        Assert.True(pokerHand.IsSecret);
    }
}