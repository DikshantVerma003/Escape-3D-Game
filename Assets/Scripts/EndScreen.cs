using UnityEngine;
using UnityEngine.UI;

public class EndScreenManager : MonoBehaviour
{
    public Text endScreenTimerText; // Reference to the UI Text element for the timer

    void Start()
    {
        float elapsedTime = PlayerPrefs.GetFloat("ElapsedTime", 0f);
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        endScreenTimerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}
