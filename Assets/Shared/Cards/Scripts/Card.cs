using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardAsset cardInfo;
        [SerializeField] private Clickable clickableComponent;
        [SerializeField] private MeshRenderer cardMeshRenderer;
        
        private static readonly int TopColor = Shader.PropertyToID("_Top_Color");
        private static readonly int BottomColor = Shader.PropertyToID("_Bottom_Color");
        public Health Health { get; set; }
        

        private void Awake()
        {
            InitializeCard();
        }

        private void InitializeCard()
        {
            Health = new Health(cardInfo.GetBaseHealth(), cardInfo.GetBaseHealth());

            foreach (var ability in cardInfo.GetAbilities())
            {
                foreach (var abilityBehaviour in ability.AbilityBehaviours.Select(abilityBehaviour => Instantiate(abilityBehaviour, transform)))
                {
                    abilityBehaviour.name = ability.AbilityName;
                }
            }

            InitializeCardMaterial();
            
            BaseValueClass.OnBaseValueUpdated?.Invoke();
        }

        public string GetCardName() => cardInfo.cardName;
        public string GetCardDescription() => cardInfo.cardDescription;

        public List<Ability> GetCardAbilities() => cardInfo.GetAbilities();

        private void OnEnable()
        {
            clickableComponent.OnClick += SelectCard;
        }

        private void OnDisable()
        {
            clickableComponent.OnClick -= SelectCard;
        }

        private void SelectCard()
        {
            GameManager.OnCardSelected?.Invoke(this);
        }

        private void InitializeCardMaterial()
        {
            var material = cardMeshRenderer.material;
            
            var elements = cardInfo.GetCardElements();

            if (elements.Count > 1)
            {
                material.SetColor(TopColor, elements[0].elementColor);
                material.SetColor(BottomColor, elements[1].elementColor);
            }
            else
            {
                material.SetColor(TopColor, elements[0].elementColor);
                material.SetColor(BottomColor, elements[0].elementColor);
            }
        }
    }
}
