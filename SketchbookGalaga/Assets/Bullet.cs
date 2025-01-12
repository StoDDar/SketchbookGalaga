using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public float destroyValue = 2f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    void Update()
    {
        DestroyAfterLeftScreen();
    }
    void DestroyAfterLeftScreen()
    {
        if (transform.position.y > destroyValue)
        {
            Destroy(gameObject);
        }
    }
}  
