using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleGUI : MonoBehaviour
{
    [SerializeField] private Text startText;
    private float updateTime;
    private float fadeSpeed = 0.75f;
    
    void Start()
    {
        updateTime = 0;
    }

    void Update()
    {
        startText.color = FadeAlphaColor(startText.color);
    }

    private Color FadeAlphaColor(Color _c)
    {
        updateTime += Time.deltaTime * 5.0f * fadeSpeed;
        _c.a = Mathf.Sin(updateTime) * 0.5f + 0.5f;

        return _c;
    }
}
