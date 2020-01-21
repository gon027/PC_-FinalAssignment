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

    public GameObject[] moles;
    private int moleLength;

    void Start()
    {
        hammer = hammerObject.GetComponent<Hammer>();

        // ゲームが始まるともぐらのオブジェクトを全て非表示にする
        foreach (Transform e in pearent.transform)
        {
            e.gameObject.SetActive(false);
        }

        // 後に使いやすくするために、parentから子要素を配列に格納する
        moleLength = pearent.transform.childCount;
        moles = new GameObject[moleLength];
        for (int i = 0; i < moleLength; i++)
        {
            moles[i] = pearent.transform.GetChild(i).gameObject;
            //moles[i].transform.gameObject.SetActive(false);
//            Debug.Log();
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
            yield return new WaitForSeconds(Random.Range(2.0f, 4.0f));
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
                    e.GetComponent<Character>().isActive = true;
                    e.gameObject.SetActive(true);
                }
            }
        }
    }
}
