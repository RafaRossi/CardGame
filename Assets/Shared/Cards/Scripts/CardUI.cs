using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Game;
using TMPro;
using UnityEngine;

public class CardUI : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private TMP_Text cardNameText;
    
    [SerializeField] private Card card;
    
    private void OnEnable()
    {
        BaseValueClass.OnBaseValueUpdated += UpdateUI;
    }

    private void OnDisable()
    {
        BaseValueClass.OnBaseValueUpdated -= UpdateUI;
    }
    
    private void UpdateUI()
    {
        healthText.text = card.Health.Value.ToString(CultureInfo.CurrentCulture);
        cardNameText.text = card.GetCardName();
    }
}
