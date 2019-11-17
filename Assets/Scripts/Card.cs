using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    string about;
    string title;
    public enum Type { CodeTroubles, SocialTroubles, OutsideTroubles }


    public Card(string _about, string _title)
    {
        about = _about;
        title = _title;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
