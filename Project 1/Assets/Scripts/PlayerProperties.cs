using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Found this code to follow at: https://learn.unity.com/tutorial/creating-properties?projectId=5c88f2c1edbc2a001f873ea5#5c88eec6edbc2a001f2afc3b
public class PlayerProperties : MonoBehaviour
{
    private int experience;

    public int Experience
    {
        get
        {
            return experience; 
            
        }
        set
        {
            experience = value;
            
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
            
        }
    }
    
    public int Health { get; set; }
}
