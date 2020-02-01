using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This Script is from a learning Unity Demo (https://unity3d.com/learning-c-sharp-in-unity-for-beginners)
public class DemoLightScript : MonoBehaviour
{
    public Light myLight;

    private void Awake()
    {
        int myVar = AddTwo(9, 2);
        Debug.Log(myVar);
    }

    private void Update()
    {
        if (Input.GetKeyDown("Space"))
        {
            MyFunction();
        }
    }

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;
    }

    int AddTwo(int var1, int var2)
    {
        int retrunValue = var1 + var2;
        return retrunValue;
    }
}
