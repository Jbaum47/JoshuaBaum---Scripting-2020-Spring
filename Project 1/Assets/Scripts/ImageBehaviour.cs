using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
  private Image imageObj;
  
  private void Start()
  {
    imageObj = GetComponent<Image>();
  }
}
