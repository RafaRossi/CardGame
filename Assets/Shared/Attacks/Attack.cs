using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "Attack")]
    public class Attack : ScriptableObject
    {
        [SerializeField] private string attackName;
        [SerializeField] private Element attackType;

        [SerializeField] private Target[] targets;

        public string GetAttackName() => attackName;
        public Element GetAttackType() => attackType;

        public Target[] GetTargets() => targets;
    }
}
