using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
  private Image imageObj;
  public float health;

  private void Start()
  {
    imageObj = GetComponent<Image>();
  }

  public void Update()
  {
    imageObj.fillAmount = health;
    
    if (imageObj.fillAmount > .5)
    {
      imageObj.color = Color.green;
    }
    if (imageObj.fillAmount <= .5)
    {
      imageObj.color = Color.yellow;
    }

    if (imageObj.fillAmount <=.25)
    {
      imageObj.color = Color.red;
    }
  }
}
