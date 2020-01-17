using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    
    private Animator animator;
    public bool hitCheck { get; set; }

    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);
    }

    void Update() {
        if (Input.GetKey(KeyCode.G))
        {
            animator.SetBool("is_Action", true);
        }
        else
        {
            animator.SetBool("is_Action", false);
        }
    }

    public void Action()
    {
        animator.SetBool("is_Action", true);
    }

    void  OnTriggerEnter(Collider other) {
        if (other.CompareTag("moguraTest")){
            Debug.Log("HIT!!!");
            hitCheck = true;
        }
    }

    void OnTriggerExit(Collider other) {
        hitCheck = false;
    }
}
