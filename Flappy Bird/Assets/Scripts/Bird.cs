using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float velocity = 1.5f;
    private Rigidbody2D rigidBody;
    public Game game;
    public State state;

    public enum State
    {
        preStart,
        running
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.preStart:
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    state = State.running;
                    gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    rigidBody.velocity = Vector2.up * velocity;
                }
                break;
            case State.running:
               if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    rigidBody.velocity = Vector2.up * velocity;
                }
                break; 
        }
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        game.GameOver();
    }
}
