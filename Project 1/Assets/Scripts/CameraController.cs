using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    private Camera cameraObj;
    public Vector3 cameraPosition;
    public float speed = 10f;
    
    void Start()
    {
        cameraObj.GetComponent<Camera>();
    }
    
    void Update()
    {
        cameraPosition.x = Input.GetAxis("Horizontal") * speed;
    }
}
