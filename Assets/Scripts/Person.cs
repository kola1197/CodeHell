using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public int power = 1;
    List<Item> items = new List<Item>();
    Impact SocialImpact;
    Impact CodeImpact;
    Impact OutsideImpact;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool AddItem(Item item)
    {
        bool result = false;
        if (items.Count < 5)
        {
            items.Add(item);
            UpdatePower();
            result = true;
        }
        return result;
    }


    bool RemoveItem(int i)
    {
        bool result = false;
        if (items.Count > i)
        {
            items.RemoveAt(i);
            UpdatePower();
            result = true;
        }
        return result;
    }

    void UpdatePower()
    {
        foreach(Item item in items)
        {
            power += item.power;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
