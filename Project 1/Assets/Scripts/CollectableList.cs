using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableList : ScriptableObject
{
    public List<Collectable> collectables;
    public Collectable collectableItem;

    public void AddToCollectableList(Collectable collectableObj)
    {
        collectables.Add(collectableObj);
    }

    public void RemoveFromCollectableList()
    {
        for (int i = 0; i < collectables.Count; i++)
        {
            if (collectables[i] == collectableObj)
            {
                collectables.Remove(collectableObj);
            } 
        }
    }

    public void CheckList()
    {
        foreach (var obj in collectables)
        {
            if (obj == collectableItem)
            {
                Debug.Log(obj);
            }
        }
    }


}
