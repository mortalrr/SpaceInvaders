using System;
using UnityEngine;

// Technique for making sure there isn't a null reference during runtime if you are going to use get component
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D myRigidbody2D;

    //-----------------------------------------------------------------------------
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    //-----------------------------------------------------------------------------
    
    private void Fire()
    {
        myRigidbody2D.velocity = Vector2.up * speed;
        Debug.Log("Wwweeeeee");
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(this.gameObject);
    }
}
