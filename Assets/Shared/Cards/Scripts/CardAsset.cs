using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "Card")]
    public class CardAsset : ScriptableObject
    {
        [SerializeField] private List<Element> elements = new List<Element>();
        [SerializeField] private List<AttackBehaviour> attackBehaviour = new List<AttackBehaviour>();

        [SerializeField] private float baseHealth;

        public float GetBaseHealth() => baseHealth;
    }
}