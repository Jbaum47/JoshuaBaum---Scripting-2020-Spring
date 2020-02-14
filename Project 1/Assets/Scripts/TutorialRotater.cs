using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Found this Script at: https://learn.unity.com/project/roll-a-ball-tutorial?courseId=5c61706dedbc2a324a9b022d
public class TutorialRotater : MonoBehaviour
{
   private void Update()
   {
      transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
   }
}
