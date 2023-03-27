using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardAsset cardInfo;
        public Health Health { get; set; }

        private void Awake()
        {
            InitializeCard();
        }

        private void InitializeCard()
        {
            Health = new Health(cardInfo.GetBaseHealth(), cardInfo.GetBaseHealth());
        }
    }
}
