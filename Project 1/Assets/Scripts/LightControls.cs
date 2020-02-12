using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightControls : MonoBehaviour
{
    private Light lightControllerObj;
    public Vector3 lightDirection;
    public float lightIntesity;
        void Start()
        { 
            lightControllerObj = GetComponent<Light>();
            
            lightControllerObj.intensity = 0f;
    }
    
    void Update()
    {
        
    }
}
