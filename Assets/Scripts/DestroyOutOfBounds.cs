using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBounds = 35.0f;
    private float lowerBounds = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBounds){
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
