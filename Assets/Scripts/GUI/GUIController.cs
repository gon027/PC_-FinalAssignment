using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    [SerializeField] private GameManager gManager;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timeText;

    private static string scoreStr = "Score: ";
    private static string timeStr = "Time: ";

    void Start()
    {
        scoreText.text = scoreStr + 0.ToString();
        timeText.text = timeStr + 0.ToString();
    }
    
    void Update()
    {
        scoreText.text = scoreStr + gManager.score.ToString("00");
        timeText.text = timeStr + gManager.time.ToString("00");
    }
}
