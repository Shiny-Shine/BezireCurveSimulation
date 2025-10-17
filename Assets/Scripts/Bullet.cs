using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bSpeed = 5f;
    private Rigidbody2D rb2d;
    private Vector3 moveUp;
    
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveUp = new Vector2(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > Camera.main.transform.position.y + Camera.main.orthographicSize)
            Destroy(gameObject);
        
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(transform.position + (moveUp * Time.deltaTime));
    }
}
