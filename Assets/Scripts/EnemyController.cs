using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // 値を取得するためのGameObject
    [SerializeField] private GameObject hammerObject;
    private Hammer hammer;
    
    // ゲーム内で使う敵のプレハブ
    [SerializeField] private GameObject pearent;
    [SerializeField] private GameObject mole;
    [SerializeField] private GameObject evilMole;

    void Start()
    {
        hammer = hammerObject.GetComponent<Hammer>();
//        Debug.Log(hammer);
       

        foreach (Transform e in pearent.transform)
        {
            e.gameObject.SetActive(false);
        }

        StartCoroutine(Exec());
    }

    void Update()
    {
        Debug.Log(hammer.hitMole1Check);
        if (hammer.hitMole1Check)
        {
            pearent.transform.GetChild(0).gameObject.SetActive(false);
        }
        
        if (hammer.hitMole2Check)
        {
            pearent.transform.GetChild(1).gameObject.SetActive(false);
        }
        
        if (hammer.hitMole3Check)
        {
            pearent.transform.GetChild(2).gameObject.SetActive(false);
        }
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
