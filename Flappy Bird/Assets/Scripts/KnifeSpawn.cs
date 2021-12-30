using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawn : MonoBehaviour
{
    public float knifeTime = 1;
    float timer = 0;
    public float height;
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newKnife = Instantiate(knife);
        newKnife.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > knifeTime)
        {
        GameObject newKnife = Instantiate(knife);
        newKnife.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newKnife, 4);
        timer = 0;
        }
        timer += Time.deltaTime;
    }
}
