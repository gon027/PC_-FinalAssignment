using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static readonly Vector3 pos1 = new Vector3(-2.13f, 1.38f, -4.8f);
    private static readonly Vector3 pos2 = new Vector3(1.45f, 1.38f, 0.2f);
    private static readonly Vector3 pos3 = new Vector3(3.82f, 1.38f, -4.8f);
    
    [SerializeField] private GameObject hammer;
    private bool isVisible;
    private float existTime;
    
    void Start()
    {
        hammer.SetActive(false);
        isVisible = false;
        existTime = 0.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            HammerPos(pos1);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            HammerPos(pos2);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            HammerPos(pos3);
        }

        if (Input.GetKey(KeyCode.K))
        {
            hammer.SetActive(false);
        }
    }

//    IEnumerator VisibleHammer()
//    {
//        while (isVisible)
//        {
//            
//            yield return null;
//        }
//    }

    void HammerPos(Vector3 _pos)
    {
        isVisible = true;
        hammer.SetActive(true);
        hammer.transform.position = _pos;
    }
}
