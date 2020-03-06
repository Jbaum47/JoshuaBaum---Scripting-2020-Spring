using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class DropdownBehaviour : MonoBehaviour
{
    private Dropdown dropdownObj;

    private void Start()
    {
        GetComponent<Dropdown>();
    }
}
