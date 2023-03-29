using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [Serializable]
    public class PlayerLevel
    {
        public int Level;
        public float CurrentXPAmount;

        public PlayerLevel(int currentLevel, float xpAmount)
        {
            Level = currentLevel;
            CurrentXPAmount = xpAmount;
        }

        public void AddXP(float xpAmount)
        {
            CurrentXPAmount += xpAmount;
        }

        public void IncreasePlayerLevel()
        {
            Level++;
        }
    }

    
}