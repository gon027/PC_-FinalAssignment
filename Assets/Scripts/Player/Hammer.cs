using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    private Animator animator;
 
    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);
    }

    void Update() {
        //Debug.Log("hit1 : " + hitMole1Check);
    }

    public void Action()
    {
        animator.SetBool("is_Action", true);
//        animator.SetBool("is_Action", false);
    }
}
