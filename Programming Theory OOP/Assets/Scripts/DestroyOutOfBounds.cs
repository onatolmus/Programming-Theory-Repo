using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 50.0f;
    private float lowerBound = -50.0f;
    private float leftBound = -50f;
    private float rightBound = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerBound ||
    transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
