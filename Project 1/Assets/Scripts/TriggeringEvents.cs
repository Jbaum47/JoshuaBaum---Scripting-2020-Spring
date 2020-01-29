
using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public float fNumber;
    public int iNumber;
    public string sNumber;
    public UnityEvent TriggerEnters;
    public UnityEvent TriggerStays;
    public UnityEvent TriggerExits;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnters.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        TriggerStays.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExits.Invoke();
    }
}
