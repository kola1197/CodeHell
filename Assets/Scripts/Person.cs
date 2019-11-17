using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public Dictionary<Card.Type, int> power = new Dictionary<Card.Type, int>();
    public List<Item> items = new List<Item>();
    Impact SocialImpact;
    Impact CodeImpact;
    Impact OutsideImpact;

    public Person()
    {
        power.Add(Card.Type.CodeTroubles, 1);
        power.Add(Card.Type.OutsideTroubles, 1);
        power.Add(Card.Type.SocialTroubles, 1);
    }

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
            power[item.type] += item.power;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
