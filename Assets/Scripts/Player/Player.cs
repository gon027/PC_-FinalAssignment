using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject hammer;
    
    void Start()
    {
        hammer.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            hammer.SetActive(true);
        }

        if (Input.GetKey(KeyCode.K))
        {
            hammer.SetActive(false);
        }
    }
}
