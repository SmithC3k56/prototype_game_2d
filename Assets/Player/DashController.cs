using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dashDistance = 5f;
    public float dashDuration = 0.2f;

    private bool isDashing = false;
    private Vector3 dashTarget;
    private float dashTimer;
    private Vector3 mousePosition;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        // Check for input to start dashing
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing)
        {
            StartDash();
        }
        // Move the player
        if (isDashing)
        {
            dashTimer += Time.deltaTime;

            if (dashTimer <= dashDuration)
            {
                transform.position = Vector3.Lerp(transform.position, dashTarget, dashTimer / dashDuration);
            }
            else
            {
                isDashing = false;
            }
        }
        else
        {
            // Regular movement code goes here...
        }
    }

    void StartDash()
    {
        isDashing = true;
        dashTarget = transform.position + (mousePosition - transform.position).normalized * dashDistance;
        dashTimer = 0f;

    }


}
