using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBird : MonoBehaviour
{
    public Transform bird;
    public float speed;
    public float rotationSpeed = 200f;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)bird.position - rigidBody.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.right).z;
        rigidBody.angularVelocity = -rotateAmount * rotationSpeed;
        rigidBody.velocity = transform.right * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
