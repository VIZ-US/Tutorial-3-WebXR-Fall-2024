using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManipulator : MonoBehaviour
{
   private float speed = 20.0f; // regular speed
   private float accel = 0.5f; // for camera accelerate


   private float yaw = 0.0f; // for camera y-rotation
   private float pitch = 0.0f; // for camera x-rotation


   private float rotSens = 3.0f; // rotation sensitivity
   // Start is called before the first frame update
   void Start()
   {



   }


   // Update is called once per frame
   void Update()
   {
       // camera rotation
    //    yaw += Input.GetAxis("Mouse X") * rotSens;
    //    pitch -= Input.GetAxis("Mouse Y") * rotSens;
    //    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


       Vector3 v = new Vector3();


       if (Input.GetKey("h"))
       {
           v += Vector3.forward;
       }  
       v = v * speed * Time.deltaTime;
       transform.Translate(v);
   }
}
