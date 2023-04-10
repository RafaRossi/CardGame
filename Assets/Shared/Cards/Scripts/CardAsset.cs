using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "Card")]
    public class CardAsset : ScriptableObject
    {
        [SerializeField] private List<Element> elements = new List<Element>();
        [SerializeField] private List<Ability> ability = new List<Ability>();

        public string cardName;

        [TextArea] public string cardDescription;

        [SerializeField] private float baseHealth;

        public float GetBaseHealth() => baseHealth;
        public List<Ability> GetAbilities() => ability;

        public List<Element> GetCardElements() => elements;
    }
}