using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector2 movement;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Debug.Log(direction);
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
