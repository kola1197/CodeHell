using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour
{
    Person person = new Person();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool Fight(Monster card)
    {
        bool result = false;
        if (person.power[card.type] > card.power)
        {
            result = true;   
        }
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
