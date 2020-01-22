using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static float MAXTIME = 5.0f;
    
    [SerializeField] private GameObject enemyController;
    private EnemyController eController;
    
    public static int score { get; set; }
    public float time { get; set; }
    public bool timeupFlag { get; set; }
    public static int countDownTime;

    public static GameState gameState;
    
    void Start()
    {
        eController = enemyController.GetComponent<EnemyController>();
        time = GameManager.MAXTIME;
        timeupFlag = false;
        score = 0;
        countDownTime = 3;

        gameState = GameState.None;

        StartCoroutine(CountDown());
    }

    void Update()
    {
        CountTime();
        CalcScore();
        StartCoroutine(WaitSeconds());
    }

    void CountTime()
    {
        if(gameState == GameState.None) return;
        
        if (!(time <= 0.0f))
        {
//            Debug.Log(time);
            time -= Time.deltaTime;
        }
        else
        {
            gameState = GameState.None;
            timeupFlag = true;
        }
    }

    void CalcScore()
    {
        for (int i = 0; i < 3; i++)
        {
            if (eController.moles[i].GetComponent<Character>().hitCheck)
            {
                score++;
                eController.moles[i].GetComponent<Character>().HideGameObject();
            }
        }
    }

    IEnumerator WaitSeconds()
    {
        if (!timeupFlag)
        {
            yield break;
        }
        
//        Debug.Log("Wait");
        
        yield return new WaitForSeconds(3.0f);
//        Debug.Log("TimeUP!!");
//        
        SceneManager.LoadScene("Result");
    }

    // スタート時カウントダウンする
    IEnumerator CountDown()
    {
        while (countDownTime > 0)
        {
            yield return new WaitForSeconds(1.0f);
            countDownTime--;
        }

        gameState = GameState.Running;
    }
}
