using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 2f;
    public float jumpForce = 30f;
    void Start()
    {
        
    }
    
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
       
        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.y -= gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
