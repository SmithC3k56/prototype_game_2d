using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public float followSpeed = 5f;
    public float shootingRange = 10f;
    public float fireRate = 0.5f;

    private float fireTimer = 0f;

    void Update()
    {
        // Follow the player
        transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * followSpeed);

        // Shoot at enemies
        fireTimer += Time.deltaTime;

        // Check for nearby enemies
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, shootingRange);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy") && fireTimer >= fireRate)
            {
                // Calculate direction to the enemy
                Vector3 direction = collider.transform.position - transform.position;
                direction.Normalize();

                // Instantiate bullet
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                //bullet.GetComponent<PetBulletController>().SetDirection(direction);

                // Reset fire timer
                fireTimer = 0f;
            }
        }
    }
}
