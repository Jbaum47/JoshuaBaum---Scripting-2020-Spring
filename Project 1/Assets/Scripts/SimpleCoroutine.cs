using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCoroutine : MonoBehaviour
{
    public float seconds = 1f;
    private WaitForSeconds waitObj;
    public bool canRun = true;
    public UnityEvent repeatEvent;

    private void Awake()
    {
        waitObj = new WaitForSeconds(seconds);
    }

    public void Reset()
    {
        StartCoroutine(OnStartCoroutine());
    }

    public IEnumerator OnStartCoroutine()
    {
        while (canRun)
        {
            repeatEvent.Invoke();
            yield return waitObj;
        }
    }
}
