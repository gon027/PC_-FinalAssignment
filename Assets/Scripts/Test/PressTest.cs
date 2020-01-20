using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PressTest : MonoBehaviour
{
    SerialPort stream = new SerialPort("/dev/cu.usbmodem14202", 57600);
    private bool isPressedA, isPressedB, isPressedC;
    private string message;

    public bool IsPressedA {
        get { return isPressedA; }
    }
    
    public bool IsPressedB {
        get { return isPressedB; }
    }
    
    public bool IsPressedC {
        get { return isPressedC; }
    }

    void Start() {
        stream.ReadTimeout = 10;
        stream.Open();
        stream.DiscardInBuffer ();

        isPressedA = false;
        isPressedB = false;
        isPressedC = false;
    }
 
    // Update is called once per frame
    void Update() {
        try{
            //Debug.Log (stream.ReadLine ());
            message = stream.ReadLine();
            //Debug.Log(message);
            if (message.Equals("pressA")) {
                isPressedA = true;
            }
            else {
                isPressedA = false;
            }
            
            if (message.Equals("pressB")) {
                isPressedB = true;
            }
            else {
                isPressedB = false;
            }
            
            if (message.Equals("pressC")) {
                isPressedC = true; 
            }
            else {
                isPressedC = false;
            }
        }
        catch(System.Exception){
            
        } 
    }

    void MassageCheck(string _message, ref bool _isPressed)
    {
        
    }
}
