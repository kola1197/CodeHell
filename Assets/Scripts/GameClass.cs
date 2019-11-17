using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameClass : MonoBehaviour
{
    public CapsuleCollider collider;
    Card[] threeCards;
    Person person = new Person();
    GameCards gameCards = new GameCards();
    bool test = false;
    // Start is called before the first frame update
    void Start()
    {
        if (test)
        {
            collisionWithCard();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        collisionWithCard();
    }
    

    void saveMostValuableItems()
    {
        List<Item> savedItems = ListSerializer.Load<List<Item>>("SavedItems.bin");
        List<Item> sortedItems = person.items.OrderByDescending(item => item.power).ToList();
        int numOfItems = savedItems.Count() + 1;
        if (numOfItems > 4)
            numOfItems = 4;
        List<Item> mostValuableItems = sortedItems.GetRange(0, numOfItems);
        ListSerializer.Save("SavedItems.bin", mostValuableItems);
    }

    List<Item> loadMostValuableItems()
    {
        List<Item> loadedItems = ListSerializer.Load<List<Item>>("SavedItems.bin");
        return loadedItems;
    }

    bool Fight(Monster card)
    {
        bool result = false;
        if (person.power[card.type] > card.power)
        {
            result = true;   
        }
        print("Fight result - " + result.ToString());
        return result;
    }

    void collisionWithCard()
    {
        threeCards = new Card[3];
        for (int i=0;i<threeCards.Length;i++)
        {
            threeCards[i] = gameCards.GetCard();
        }
        ShowCards(threeCards);
    }

    void getRevard()
    {
        Card revard = gameCards.GetItems();
        print("Revard " + revard.title + " about --- " + revard.about.ToString());

    }

    void ShowCards(Card [] threeCards)
    {
        CardChosen(1);      ////////////////////////////////////remove
    }

    void CardChosen(int i)
    {
        print(threeCards[i].title + " _______________" + threeCards[i].about);
        if (threeCards[i] is Monster)
        {
            if (Fight((Monster)threeCards[i]))
            {
                person.ClearImpacts();
                getRevard();            
            }
            else
            {
                deadVoid();
                print("YOU DEAD");
            }
        }
    }


    void deadVoid()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
