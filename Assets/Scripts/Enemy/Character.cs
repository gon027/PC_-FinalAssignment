using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool hitCheck { get; set; }
    public bool scoreCheck { get; set; }
    
    void Start()
    {
        hitCheck = false;
    }

    void Update()
    {
        
    }
    
    void  OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hammer"))
        {
            Debug.Log("Mole::OnTriggerEnter");
            hitCheck = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Mole::OnTriggerExit");
        if (other.CompareTag("Hammer"))
        {
            Debug.Log("Mole::OnTriggerExit::IF");
            hitCheck = false;
            scoreCheck = true;
            this.gameObject.SetActive(false);
        }
    }
}
