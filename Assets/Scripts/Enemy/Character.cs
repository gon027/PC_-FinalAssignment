using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool hitCheck { get; set; }
    public bool isActive { get; set; }
    
    void Start()
    {
        hitCheck = false;
        isActive = false;
    }

    void Update()
    {
        StartCoroutine(ActiveCheck());
    }
    
    void  OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hammer"))
        {
            Debug.Log("Mole::OnTriggerEnter");
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Mole::OnTriggerExit");
        if (other.CompareTag("Hammer"))
        {
            Debug.Log("Mole::OnTriggerExit::IF");
            hitCheck = true;
            isActive = false;
            this.gameObject.SetActive(false);
        }
    }

    public void HideGameObject()
    {
        hitCheck = false;
    }

    IEnumerator ActiveCheck()
    {
        if(!isActive) yield break;
        
        Debug.Log("Character::Test");

        yield return new WaitForSeconds(Random.Range(2.0f, 4.0f));
        
        isActive = false;
        this.gameObject.SetActive(false);
    }
}
