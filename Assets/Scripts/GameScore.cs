using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    private static GameScore instance;
    private int score = 0;

    public static GameScore Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject("GameScore");
                instance = obj.AddComponent<GameScore>();
            }

            return instance;
        }
    }

    public void addScore(int _n)
    {
        Debug.Log(12345432123456543);
        score += _n;
    }

    public int getScore()
    {
        return score;
    }

    public void ClearScore()
    {
        score = 0;
    }
}
