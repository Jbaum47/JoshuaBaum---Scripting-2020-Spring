using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInventoryItem
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public TutorialInventoryItem(int id, string description, Sprite icon, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = icon;
        this.stats = stats;
    }

    public TutorialInventoryItem(TutorialInventoryItem item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.stats = item.stats;
    }
}
