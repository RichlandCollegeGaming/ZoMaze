using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 60f; // Total time in seconds
    public Text timerText; // Reference to the UI text component to display the timer

    private float currentTime; // Current time left
    [SerializeField] private GameObject WholePlayer;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        // Update current time
        currentTime -= Time.deltaTime;

        // Ensure time doesn't go below 0
        if (currentTime < 0)
        {
            currentTime = 0;
            // Load scene by name once timer ends
            Destroy(WholePlayer);
            LoadScene();
        }

        // Update UI text to display time
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        // Convert time to minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        // Update UI text to display time in mm:ss format
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadScene()
    {
        // Replace "YourSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("WinScreen");
    }
}
