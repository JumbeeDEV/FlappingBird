using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 0;
    public float deadZone = -45;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        
        {

        }
    }
}
