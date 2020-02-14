using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Found this Script at: https://learn.unity.com/project/roll-a-ball-tutorial?courseId=5c61706dedbc2a324a9b022d
public class TutorialCameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
