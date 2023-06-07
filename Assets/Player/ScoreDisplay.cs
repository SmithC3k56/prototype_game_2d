using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public ScoreData scoreData;
    private Text scoreText;
    private Transform playerTransform;

    private void Start()
    {
        // Get the Text component from the Text object
        scoreText = GetComponent<Text>();

        // Get a reference to the player's transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Update the position of the text to be above the player's head
        transform.position = playerTransform.position + Vector3.up * 2f;

        // Update the displayed score
        scoreText.text = "Score: " + scoreData.score.ToString();
    }
}
