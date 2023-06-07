using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetBulletController : MonoBehaviour
{
    public float bulletSpeed = 10f; // The speed of the bullet
    public float bulletLifetime = 5f; // The lifetime of the bullet in seconds

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed; // Move the bullet in its forward direction

        // Destroy the bullet after the specified lifetime
        Destroy(gameObject, this.bulletLifetime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Handle the bullet hitting an enemy
            Destroy(collision.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
