using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using UnityEngine;

public class StatisticsTest
{
    [Test]
    public void MustHaveAtLeastOneMatch()
    {
        Matches matches = new Matches(0);
        
        Assert.NotZero(matches.Value);
    }
    
    [Test]
    public void CheckWinRate()
    {
        //Verfica a quantidade de vitorias e derrotas do jogador, e calcula a porcentagem.
        WinRate winRate = new WinRate(new Victories(1), new Matches(3));

        Assert.AreEqual(50f, winRate.Value);
    }

    [Test]
    public void MustHaveMatchToHaveMatchLog()
    {
        //Uma partida deve ter um tempo maior que zero, se não ela não ocorreu, logo, não deve ser registrada.
        MatchLog matchLog = new MatchLog(0f, false);

        Assert.IsTrue(matchLog.MatchTime > 0f);
    }

    [Test]
    public void AccessStatisticsScene()
    {
        var sceneName = "Statistics";
        SceneManager.LoadScene(sceneName);

        Assert.IsTrue(SceneManager.GetSceneByName("Statistics").isLoaded);
    }

    [Test]
    public void PlayerLevelMustBeGreterThanZero()
    {
        PlayerLevel playerLevel = new PlayerLevel(0, 4);

        Assert.IsTrue(playerLevel.Level > 0);
    }


    [Test]
    public void AddExperienceToPlayer()
    {
        PlayerLevel playerLevel = new PlayerLevel(2, 40);

        var previousPlayerLevel = playerLevel.Level;

        playerLevel.AddXP(10f);

        Assert.AreEqual(playerLevel.Level, previousPlayerLevel + 10f);
    }

    [Test]
    public void IncreasePlayerLevel()
    {
        PlayerLevel playerLevel = new PlayerLevel(3, 50);

        var previousPlayerLevel = 0;

        playerLevel.IncreasePlayerLevel();

        Assert.AreEqual(playerLevel.Level, previousPlayerLevel + 1);
    }
    
}
