using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 2f;
    public float jumpForce = 30f;
    private int jumpCount = 0;
    public int jumpCountMax = 2;
    public UnityEvent jumpEvent;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
       
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        positionDirection.y -= gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
