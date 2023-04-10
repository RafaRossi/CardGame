using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using TMPro;

public class CardSelectionUI : MonoBehaviour
{
    [SerializeField] private TMP_Text cardNameText;
    [SerializeField] private TMP_Text cardDescriptionText;
    [SerializeField] private GameObject cardSelectionPanel;

    [SerializeField] private List<CardAbilityButton> cardAbilityButtons = new List<CardAbilityButton>();

    private void OnEnable()
    {
        GameManager.OnCardSelected += UpdateUI;
    }
    

    private void OnDisable()
    {
        GameManager.OnCardSelected -= UpdateUI;
    }
    
    private void UpdateUI(Card card)
    {
        cardNameText.text = card.GetCardName();
        
        InitializeCardAbilityButtons(card);
        
        UpdateCardDescriptionText(card.GetCardDescription());

        if (!cardSelectionPanel.activeSelf)
        {
            ShowCardSelectionUI();
        }
    }

    private void ShowCardSelectionUI()
    {
        cardSelectionPanel.SetActive(true);
    }

    private void HideSelectionUI()
    {
        cardSelectionPanel.SetActive(false);
    }

    private void UpdateCardDescriptionText(string cardDescription)
    {
        cardDescriptionText.text = cardDescription;
    }

    private void InitializeCardAbilityButtons(Card card)
    {
        foreach (var cardAbilityButton in cardAbilityButtons)
        {
            cardAbilityButton.gameObject.SetActive(false);
        }
        
        for (var i = 0; i < card.GetCardAbilities().Count && i < cardAbilityButtons.Count; i++)
        {
            cardAbilityButtons[i].Initialize(card.GetCardAbilities()[i]);
        }
    }
}
