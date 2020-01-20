using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 時間管理、スコア管理
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyController;
    [SerializeField] private GameObject playerObject;
    private EnemyController eController;
    private Player player;
    
    public int score { get; set; }
    private const float MAXTIME = 60.0f;
    private float time;
    
    void Start()
    {
        eController = enemyController.GetComponent<EnemyController>();
        player = playerObject.GetComponent<Player>();
        
        
        time = 0;
    }

    void Update()
    {
        
        
        CountTime();
    }

    void CountTime()
    {
        if (time >= MAXTIME)
        {
//            Debug.Log("Time UP!!!!!");
        }
        else
        {
            time += Time.deltaTime;
//            Debug.Log(time);
        }
    }
}
