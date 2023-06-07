

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShot : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab cho đối tượng đạn
    public float bulletSpeed = 10f; // Tốc độ của đạn
    private Vector2 directionBase;
    void Update()
    {
        if (Input.GetMouseButton(0)) // Kiểm tra nút chuột trái
        {
            ShootBullet();
        }
    }
    void Start()
    {
        // Áp dụng vận tốc cho đạn dựa trên hướng và tốc độ
        GetComponent<Rigidbody2D>().velocity = directionBase * bulletSpeed;
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - transform.position).normalized;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;
        directionBase = direction;
    }
     // Hướng di chuyển của đạn

    // Set hướng di chuyển của đạn
    public void SetDirection(Vector2 newDirection)
    {
        directionBase = newDirection.normalized;

        // Xoay đạn theo hướng di chuyển
        float angle = Mathf.Atan2(directionBase.y, directionBase.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
