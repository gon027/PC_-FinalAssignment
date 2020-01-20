using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 時間管理、スコア管理、他クラスの値取得のクラス
// 全ての責任を負わせない
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyController;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject hammerObject;
    private EnemyController eController;
    private Player player;
    private Hammer hammer;
    
    public int score { get; set; }
    public static float MAXTIME = 60.0f;
    public float time { get; set; }
    
    void Start()
    {
        eController = enemyController.GetComponent<EnemyController>();
        player = playerObject.GetComponent<Player>();
        hammer = hammerObject.GetComponent<Hammer>();
        
        time = GameManager.MAXTIME;
    }

    void Update()
    {
        CountTime();
        CalcScore();
    }

    void CountTime()
    {
        if (time >= MAXTIME)
        {
            time -= Time.deltaTime;
        }
    }

    void CalcScore()
    {
        for (int i = 0; i < 3; i++)
        {
            if (eController.moles[i].GetComponent<Character>().scoreCheck)
            {
                score++;
                eController.moles[i].GetComponent<Character>().scoreCheck = false;
            }
        }
    }
}
