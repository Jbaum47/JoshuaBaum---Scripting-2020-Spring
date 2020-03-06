using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonController : MonoBehaviour
{
    private Button buttonObj;
    public Text buttonText;
    private void Start()
    {
       buttonObj = GetComponent<Button>(); 
       
       buttonText.text = "Reset";
    }

    
}
   
