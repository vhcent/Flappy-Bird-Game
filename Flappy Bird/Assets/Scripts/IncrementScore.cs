using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.gameObject.name != "Bird2(Clone)")    
            Score.score ++;
        }
}
