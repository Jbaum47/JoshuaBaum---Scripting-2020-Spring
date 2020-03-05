using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInventoryCraftRecipe
{
    public int[] requiredItems;
    public int itemToCraft;

    public TutorialInventoryCraftRecipe(int itemToCraft, int[] requiredItems)
    {
        this.requiredItems = requiredItems;
        this.itemToCraft = itemToCraft;
    }
}
