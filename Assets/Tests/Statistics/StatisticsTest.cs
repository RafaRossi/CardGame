using System.Collections;
using System.Collections.Generic;
using Game;
using NUnit.Framework;
using UnityEngine;

public class StatisticsTest
{
    [Test]
    public void MustHaveAtLeastOneMatch()
    {
        Matches matches = new Matches(1);
        
        Assert.NotZero(matches.Value);
    }
    
    [Test]
    public void CheckWinRate()
    {
        WinRate winRate = new WinRate(new Victories(1), new Matches(2));

        Assert.AreEqual(50f, winRate.Value);
    }
    
}
