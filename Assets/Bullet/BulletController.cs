using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletLifetime = 5f; // The lifetime of the bullet in seconds

    void Start()
    {
        // Start the timer to destroy the bullet after the specified lifetime
        Destroy(gameObject, bulletLifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // Kiểm tra va chạm với đạn khác
        {
            // Không làm gì nếu va chạm với đạn khác
            return;
        }

        if (collision.gameObject.CompareTag("Enemy")) // Kiểm tra va chạm với enemy
        {
            Destroy(collision.gameObject); // Hủy enemy

            // Tạo hiệu ứng nổ
            //Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);

            Destroy(gameObject); // Hủy đạn
        }
    }
}