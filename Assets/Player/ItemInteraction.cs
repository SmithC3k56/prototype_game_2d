using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public float sizeIncreaseAmount = 0.1f;

    public ScoreData scoreData;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Item"))
        {
            // Increase the player's size
            gameObject.transform.localScale += new Vector3(sizeIncreaseAmount, this.sizeIncreaseAmount, 0f);
            // Increase the score
            scoreData.score++;

            // Remove the item object
            Destroy(collision.gameObject);
            //Debug.Log("Touched");
            // Add any other desired logic, such as updating score or playing a sound effect
        }
    }
}
