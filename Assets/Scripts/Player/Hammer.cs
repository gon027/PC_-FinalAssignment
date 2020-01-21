using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    // TODO: アニメーションの時間を取得して強制的に待機モーションにするようにする
    
    [SerializeField] private Animator animator;
 
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    void Update() {
        //Debug.Log("hit1 : " + hitMole1Check);
    }

    public void Action()
    {
        animator.SetBool("is_Action", true);
//        animator.Play("Action");
    }

    public void NoAction()
    {
        animator.SetBool("is_Action", false);
    }
}
