using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    
    private Animator animator;
    public bool hitCheck { get; set; }
    public bool hitMole1Check { get; set; }
    public bool hitMole2Check { get; set; }
    public bool hitMole3Check { get; set; }

    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);
    }

    void Update() {
        
    }

    public void Action()
    {
        animator.SetBool("is_Action", true);
    }

    void  OnTriggerEnter(Collider other) {
        if (other.CompareTag("Mole")){
            Debug.Log("HIT!!!");
            hitCheck = true;
        }
    }

    void OnTriggerExit(Collider other) {
        hitCheck = false;
    }
}
