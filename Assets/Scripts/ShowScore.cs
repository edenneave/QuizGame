using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public TMP_Text scoreText; // Reference to the Text component to display the score
    private int score = 0; // Variable to store the score

    // No need for isInitialized variable if we're not adding listeners in Start()

    void Start()
    {
    }

    public void IncrementScore()
    {
        score++; // Increase the score when a correct button is pressed
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString() + "/5"; // Update the score text
    }
}
