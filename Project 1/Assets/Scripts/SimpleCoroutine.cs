﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCoroutine : MonoBehaviour
{
    public float seconds = 1f;
    private WaitForSeconds waitObj;
    public bool canRun { get; set; }= true;
    public UnityEvent startEvent, repeatEvent;

    private void Awake()
    {
        waitObj = new WaitForSeconds(seconds);
    }

    private void Start()
    {
        startEvent.Invoke();
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
