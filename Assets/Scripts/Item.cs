﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Card
{

    public int power;
    public Type type;
    Item(string _title, string _about, int _power, Type _type) : base(_title, _about)
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
