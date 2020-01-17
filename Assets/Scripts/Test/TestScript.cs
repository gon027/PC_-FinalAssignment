using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private TestChild tc;
    
    // Start is called before the first frame update
    void Start()
    {
        tc.PrintTest();
    }

    // Update is called once per frame
    void Update()
    {
        tc.PrintTest_TestChild();
    }
}
