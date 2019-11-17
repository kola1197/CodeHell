using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCards : MonoBehaviour
{

    Stack<Card> cards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void GenerateCards()
    {

    }

    Card GetCard()
    {
        return cards.Pop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
