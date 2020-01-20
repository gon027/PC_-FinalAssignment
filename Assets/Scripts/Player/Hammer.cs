using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    
    private Animator animator;
    public bool hitMole1Check { get; set; }
    public bool hitMole2Check { get; set; }
    public bool hitMole3Check { get; set; }

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
        animator.SetBool("is_Action", false);
    }

    // 多分使わない
    // 別の方法が実装次第すぐ削除
    void  OnTriggerEnter(Collider other) {
        if (other.name.Equals("Mole1"))
        {
            //hitMole1Check = true;
        }
        
        if (other.name.Equals("Mole2"))
        {
//            hitMole2Check = true;
        }
        
        if (other.name.Equals("Mole3"))
        {
//            hitMole3Check = true;
        }
    }

    void OnTriggerExit(Collider other) {
        //Debug.Log(12378);
//        if (other.name.Equals("Mole1"))
//        {
            //hitMole1Check = false;
//        }
        
//        if (other.name.Equals("Mole2"))
//        {
//            hitMole2Check = false;
//        }
        
//        if (other.name.Equals("Mole3"))
//        {
//            hitMole3Check = false;
//        }
        
    }
}
