using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInventoryItemDatabase : MonoBehaviour
{
    public List<TutorialInventoryItem> items = new List<TutorialInventoryItem>();

    void Awake()
    {
        BuildItemDatabase();
    }

    public TutorialInventoryItem GetItemID(int id)
    {
        return items.Find(item => item.id == id);
    }
    
    void BuildItemDatabase()
    {
        items = new List<TutorialInventoryItem>()
        {
            new TutorialInventoryItem(1, "Diamond Sword", "A Sword made of Diamond.", 
                new Dictionary<string, int>
            {
                { "Power", 15 },
                { "Defence", 7 }
            }),
        new TutorialInventoryItem(2, "Steel Sword", "A Sword made of Steel.", 
            new Dictionary<string, int>
            {
                { "Power", 10 },
                { "Defence", 4 }
        })
        };
    }
}
