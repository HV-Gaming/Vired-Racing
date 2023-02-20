using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    public GameObject timerObject;
    private float startTime;
    public float timeLeft;
    private float coroutineTimeScale = 1; // set this to 1

    void Start()
    {
        startTime = 6f;
        timeLeft = startTime;

        StartCoroutine(Countdown());
        Time.timeScale = 0;
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSecondsRealtime(1f * coroutineTimeScale); //multiply the wait time by coroutineTimeScale
            timeLeft--;
            timerText.text = timeLeft.ToString("0");
        }

        Time.timeScale = 1;
        //timerObject.SetActive(false);
        // Do something when time is up
        timerText.text = "";
    }
}
