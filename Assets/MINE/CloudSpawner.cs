using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate = 2;
    private float timer = 0;
    public float HOffset = 10;
    public float VOffset = 10;

    void Start()
    {
        spawnObstacle();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawnObstacle();
            timer = 0;
        }

        
    }

    void spawnObstacle()
    {
        float lowestPoint = transform.position.y - HOffset;
        float highestPoint = transform.position.y + HOffset;
        float closestPoint = transform.position.x - VOffset;
        float furthestPoint = transform.position.x + VOffset;

        Instantiate(obstacle, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
        Instantiate(obstacle, new Vector3(transform.position.y, Random.Range(closestPoint, furthestPoint), 0), Quaternion.identity);
    }

}
