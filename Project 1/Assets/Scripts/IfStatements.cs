using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public string password = "OU812";
    public bool canRun = true;
    void Start()
    {
        if (canRun == true)
        {
           print("We can run."); 
        }

        if (password == "OU812")
        {
            print("That is correct.");
        }
    }
    
    void Update()
    {
        
    }
}
