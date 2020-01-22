using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    [SerializeField] private GameManager gManager;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timeText;
    [SerializeField] private Text timeUpText;
    [SerializeField] private Text countDownText;

    private static string scoreStr = "Score: ";
    private static string timeStr = "Time: ";

    void Start()
    {
        scoreText.text = scoreStr + GameManager.MAXTIME.ToString();
        timeText.text = timeStr + 0.ToString();
        timeUpText.gameObject.SetActive(false);
        countDownText.text = GameManager.countDownTime.ToString();
        countDownText.gameObject.SetActive(true);
    }
    
    void Update()
    {
        scoreText.text = scoreStr + GameManager.score.ToString("00");
        timeText.text = timeStr + gManager.time.ToString("00");
        
        if (GameManager.countDownTime > 0)
        {
            countDownText.text = GameManager.countDownTime.ToString();
        }
        else
        {
            countDownText.gameObject.SetActive(false);
        }

        if (gManager.timeupFlag)
        {
            timeUpText.gameObject.SetActive(true);
        }
    }
}
