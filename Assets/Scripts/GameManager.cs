using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 時間管理、スコア管理、他クラスの値取得のクラス
// 全ての責任を負わせない
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyController;
    private EnemyController eController;
    
    public int score { get; set; }
    public static float MAXTIME = 5.0f;
    public float time { get; set; }
    public bool timeupFlag { get; set; }
    
    void Start()
    {
        eController = enemyController.GetComponent<EnemyController>();
        time = GameManager.MAXTIME;
        timeupFlag = false;
    }

    void Update()
    {
        CountTime();
        CalcScore();
        StartCoroutine(WaitSeconds());
    }

    void CountTime()
    {
        if (!(time <= 0.0f))
        {
            Debug.Log(time);
            time -= Time.deltaTime;
        }
        else
        {
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
        
        Debug.Log("Wait");
        
        yield return new WaitForSeconds(3.0f);
        Debug.Log("TimeUP!!");
        
        //SceneManager.LoadScene("Result");
    }

    // スタート時カウントダウンする
    IEnumerator CountDownTime()
    {

        yield return new WaitForSeconds(1.0f);
    }
}
