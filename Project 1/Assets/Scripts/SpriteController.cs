using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.red;
    public Color offColor = Color.red;
    private SpriteRenderer spriteObj;
    
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
        spriteObj.color = spriteColor;
    }

    private void OnEnable()
    {
        print("This is on.");
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        print("This is off.");
        spriteObj.color = offColor;
    }

    void Update()
    {
        
    }
}
