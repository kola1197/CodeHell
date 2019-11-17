using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public Dictionary<Card.Type, int> power = new Dictionary<Card.Type, int>();
    List<Item> items = new List<Item>();
    Impact SocialImpact;
    Impact CodeImpact;
    Impact OutsideImpact;
    List<Impact> impacts = new List<Impact>();


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

    public void SetAActive(int i)
    {
        if (impacts.Count > i)
        {
            impacts[i].active = true;
        }
    }

    public void ClearImpacts()
    {
        List<Impact> l = impacts;
        for (int i = 0; i < impacts.Count; i++)
        {
            if (impacts[i].active)
            {
                l.Remove(impacts[i]);
            }
        }
        impacts = l;
    }

    bool AddItem(Item item)
    {
        bool result = false;
        if (items.Count < 4)
        {
            items.Add(item);
            UpdatePower();
            result = true;
        }
        return result;
    }

    bool AddImpact(Impact item)
    {
        bool result = false;
        if (impacts.Count < 3)
        {
            impacts.Add(item);
            UpdatePower();
            result = true;
        }
        return result;
    }

    bool RemoveImpact(int i)
    {
        bool result = false;
        if (impacts.Count > i)
        {
            impacts.RemoveAt(i);
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
        foreach (Impact imp in impacts)
        {
            if (imp.active)
            {
                power[imp.type] += imp.power;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
