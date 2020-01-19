using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // ゲーム内で使う敵のプレハブ
    [SerializeField] private GameObject pearent;
    [SerializeField] private GameObject mole;
    [SerializeField] private GameObject evilMole;
    
    void Start()
    {
        foreach (Transform e in pearent.transform)
        {
            e.gameObject.SetActive(false);
        }

        StartCoroutine(Exec());
    }

    void Update()
    {
        
    }

    IEnumerator Exec()
    {
        while (true)
        {
            GenerateEnemy();
            yield return new WaitForSeconds(3.0f);
        }
    }

    // 敵を生成する
    void GenerateEnemy()
    {
        for (int i = 0; i < 3; i++)
        {
            var e = pearent.transform.GetChild(i);
            if (e.gameObject.activeSelf == false)
            {
                bool exist = Utility.getRandomBool();
                if (exist)
                {
                    e.gameObject.SetActive(true);
                }
            }
        }
    }
}
