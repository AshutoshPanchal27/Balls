using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private new  Rigidbody2D rigidbody2D;
    
    [SerializeField]
    private float moveSpeed = 10;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;
    }
}
