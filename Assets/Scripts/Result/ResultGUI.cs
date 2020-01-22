using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultGUI : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text returnText;
    private float updateTime;
    private float fadeSpeed = 0.5f;
    
    void Start()
    {
        scoreText.text = 0.ToString("00");
        updateTime = 0;
    }
    
    void Update()
    {
        scoreText.text = GameManager.score.ToString("00");
        returnText.color = FadeAlphaColor(returnText.color);
    }
    
    private Color FadeAlphaColor(Color _c)
    {
        updateTime += Time.deltaTime * 5.0f * fadeSpeed;
        _c.a = Mathf.Sin(updateTime) * 0.5f + 0.5f;

        return _c;
    }
}
