using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public float speed = 0;
    public float deadZonex = -45;
    //public float deadZoney = 20;
    //public float deadZoneMinusy = -20;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        

        if (transform.position.x < deadZonex )
        {
            Destroy(gameObject);    
        }
        
    }
}

