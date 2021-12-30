using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float velocity = 1.5f;
    private Rigidbody2D rigidBody;
    public Game game;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        game.GameOver();
    }
}
