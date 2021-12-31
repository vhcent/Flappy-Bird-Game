using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBirdSpawn : MonoBehaviour
{
    public float homingBirdTime = 1;
    float timer = 0;
    public float height;
    public GameObject homingBird;
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
            if (timer > homingBirdTime)
            {
                GameObject newHomingBird = Instantiate(homingBird);
                newHomingBird.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                timer = 0;
            }
            timer += Time.deltaTime;
        } 
    }
}
