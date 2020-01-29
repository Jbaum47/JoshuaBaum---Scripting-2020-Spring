using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public UnityEvent mouseUpEvent;
    public UnityEvent mouseDragEvent;
    public UnityEvent mouseEnterEvent;
    public UnityEvent mouseExitEvent;
    public UnityEvent mouseOverEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
    private void OnMouseDrag()
    {
       mouseDragEvent.Invoke();
    }
    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }
    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }
}
