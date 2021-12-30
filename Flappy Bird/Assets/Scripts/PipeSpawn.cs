using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float pipeTime = 2;
    float timer = 0;
    public float height;
    public GameObject pipe;
    public Bird bird;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (bird.state == Bird.State.running)
        {
            if (timer > pipeTime)
            {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 4);
            timer = 0;
            }
            timer += Time.deltaTime;
        }
    }
}
