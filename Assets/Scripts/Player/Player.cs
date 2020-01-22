using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Vector3 pos1 = new Vector3(-2.13f, 1.38f, -4.8f);
    private static Vector3 pos2 = new Vector3(1.45f, 1.38f, 0.2f);
    private static Vector3 pos3 = new Vector3(3.82f, 1.38f, -4.8f);

    [SerializeField] private GameObject hammer;
    [SerializeField] private GameObject pressTest;
    private PressTest pTest;

    private bool isRunning;
    public bool IsRunning
    {
        set { isRunning = value; }
    }

    private bool keyHitCheck1;
    private bool keyHitCheck2;
    private bool keyHitCheck3;
    
    void Start()
    {
        pTest = pressTest.GetComponent<PressTest>();
//        Debug.Log(pTest.IsPressedA);

        keyHitCheck1 = false;
        keyHitCheck2 = false;
        keyHitCheck3 = false;

        isRunning = false;
    }

    void Update()
    {
        HammerControl();
    }

    void HammerPos(Vector3 _pos)
    {
        hammer.transform.position = _pos;
        hammer.GetComponent<Hammer>().Action();
    }

    void HammerControl()
    {
        //if(!isRunning) return;
        if (GameManager.gameState == GameState.None) return;

        if (Input.GetKey(KeyCode.A) || pTest.IsPressedA)
        {
            keyHitCheck1 = true;
            HammerPos(pos1);
        }
        else
        {
            keyHitCheck1 = false;
        }

        if (Input.GetKey(KeyCode.S) || pTest.IsPressedB)
        {
            keyHitCheck2 = true;
            HammerPos(pos2);
        }
        else
        {
            keyHitCheck2 = false;
        }
        
        if (Input.GetKey(KeyCode.D) || pTest.IsPressedC)
        {
            keyHitCheck3 = true;
            HammerPos(pos3);
        }
        else
        {
            keyHitCheck3 = false;
        }

        if (!keyHitCheck1 && !keyHitCheck2 && !keyHitCheck3)
        {
            hammer.GetComponent<Hammer>().NoAction();
        }
    }
}
