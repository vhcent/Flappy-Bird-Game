using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float velocity = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Pipe";
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
