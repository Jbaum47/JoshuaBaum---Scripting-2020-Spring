using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Found this at: https://www.youtube.com/watch?v=qmNlY4Y68o0
public class InstantiationAndSpawnerTutorial : MonoBehaviour
{
    public GameObject mPrefab;
    private void Start()
    {
        GameObject.Instantiate(mPrefab, transform.position, Quaternion.identity);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject.Instantiate(mPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
