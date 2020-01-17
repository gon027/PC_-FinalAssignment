using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraTest : MonoBehaviour{
    [SerializeField] private GameObject moguraPerient;
    [SerializeField] private GameObject[] mogura;

    void Start(){
        mogura = new GameObject[3];
        for(int i = 0; i < 3; i++){
            mogura[i] = moguraPerient.transform.GetChild(i).gameObject;
        }

        foreach(var e in mogura){
            Debug.Log(e);
        }
    }

    void Update(){
        
    }
}
