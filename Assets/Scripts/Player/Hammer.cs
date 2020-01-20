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
//        if (other.CompareTag("Mole")){
//            Debug.Log("HIT!!!");
//            hitCheck = true;
//        }

        if (other.name.Equals("Mole1"))
        {
            hitMole1Check = true;
            //Debug.Log("Mole1");
        }
        
        if (other.name.Equals("Mole2"))
        {
            hitMole2Check = true;
            //Debug.Log("Mole2");
        }
        
        if (other.name.Equals("Mole3"))
        {
            hitMole3Check = true;
            //Debug.Log("Mole3");
        }
    }

    void OnTriggerExit(Collider other) {
        hitMole1Check = false;
        hitMole2Check = false;
        hitMole3Check = false;
    }
}
