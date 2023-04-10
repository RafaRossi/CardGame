using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float delayTime;
    
    public static Action<Card> OnCardSelected = delegate(Card card) {  };

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delayTime);
        
        MatchManager.OnMatchStart?.Invoke();
    }
    
    
}
