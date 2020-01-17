using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour {
    [SerializeField] private GameObject testObject1;
    [SerializeField] private GameObject testObject2;
    [SerializeField] private GameObject testObject3;
    [SerializeField] private GameObject hummer;
    private Material tMaterial1;
    private Material tMaterial2;
    private Material tMaterial3;
    private Hammer h;
    
    void Start() {
        // ハンマーのオブジェクトを生成
        h = hummer.gameObject.GetComponent<Hammer>();
        
        // ハンマーのActiveをfalseにする
        //hummer.SetActive(false);
        
        //Debug.Log(pt.PressB);
//        tMaterial = testObject1.GetComponent<Renderer>().material;

//        Debug.Log(testObject1);
//        Debug.Log(testObject2);
//        Debug.Log(testObject3);

        tMaterial1 = testObject1.GetComponent<Renderer>().material;
        tMaterial2 = testObject2.GetComponent<Renderer>().material;
        tMaterial3 = testObject3.GetComponent<Renderer>().material;
        
//        Debug.Log(tMaterial1);
//        Debug.Log(tMaterial2);
//        Debug.Log(tMaterial3);
    }

    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            //Debug.Log(1);
            testObject1.gameObject.GetComponent<Renderer>().material.color = Color.black;
            HummerPopup(testObject1.transform.position - new Vector3(0, -1, 5));
        }
        else {
            testObject1.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKey(KeyCode.S)) {
            //Debug.Log(2);
            testObject2.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            HummerPopup(testObject2.transform.position - new Vector3(0.0f, 0.7f, 0.0f));
        }
        else {
            testObject2.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        
        if (Input.GetKey(KeyCode.D)) {
            //Debug.Log(3);
            testObject3.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            HummerPopup(new Vector3(3.81f, 1.01f, -1.59f));
        }
        else {
            testObject3.gameObject.GetComponent<Renderer>().material.color = Color.white;
            hummer.GetComponent<Animator>().SetBool("is_Action", false);
        }
        
        //Debug.Log("Hammer = " + h.hitCheck);
    }

    void HummerPopup(Vector3 _position) {
        hummer.SetActive(true);
        hummer.transform.position = _position;
        hummer.GetComponent<Animator>().SetBool("is_Action", true);
//        h.Action();
    }

    void HummerOut() {
        hummer.SetActive(false);
    }
}
