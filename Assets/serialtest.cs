using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class serialtest : MonoBehaviour {


    private float AmountToMove;


    // print(SerialPort.GetPortNames());
    // Use this for initialization
    void Start () {

        SerialPort serial = new SerialPort("\\.\COM14", 9600);

       // SerialPort serial = new SerialPort("COM14", 9600);


        serial.Open();

        serial.WriteLine("connect_to_unity 1");
        StartCoroutine("DoSomething"); // Pause

        print(serial.ReadLine());

    }

    // Update is called once per frame
    void Update () {
        // Always check if it is closed?
        //  if (!serial.IsOpen)
        //   serial.Open(); 

        //  int number = int.Parse (serial.ReadLine());

        //Debug.Log("Text");

    }



    IEnumerator DoSomething()
    {
        yield return new WaitForSeconds(5f);
        print("Ok");
    }
}


//   print("serial ports: \n");
//  string[] ports = SerialPort.GetPortNames();

//      foreach (string port in ports)
//      {
//  print(port);
//      }