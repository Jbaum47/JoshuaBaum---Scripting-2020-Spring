using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonController : MonoBehaviour
{
    private Button buttonObj;

    private void Start()
    {
        GetComponent<Button>();
    }
}
   
