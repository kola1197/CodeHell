using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Card
{
    public int power;
    enum Type { CodeTroubles, SocialTroubles ,OutsideTroubles }
    Type type;
    Monster(string _about, string _title, int _power, Type _type): base (_about, _title)
    {
        power = _power;
        type = _type;
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
