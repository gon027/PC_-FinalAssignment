using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    [SerializeField] private GameObject pressTest;
    private PressTest pTest;
    
    void Start()
    {
        pTest.GetComponent<PressTest>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }

//        if (pTest.IsPressedA || pTest.IsPressedB || pTest.IsPressedC)
//        {
//            SceneManager.LoadScene("Title");
//        }
    }
}
