using System;
using UnityEngine;
using System.Collections;

public class CollisionsTutorial : MonoBehaviour
{
    private void OnCollisionEnter(Collision collison)
    {
        Debug.Log("Enter called.");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay occuring..");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit called..");
    }
}
