using System;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{
    public UnityEvent triggerExitEvent;
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerStayEvent;

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }
}
