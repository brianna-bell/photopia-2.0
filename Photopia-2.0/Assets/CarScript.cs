using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 20.0f;
    private float distanceTraveled; 
    //public float EndPosLastRoad = 300; 
    //public GameObject roadPrefab;
    //public vector roadObj;
    //public List<GameObject> roadObj = new List<GameObject>();
    //private int roadAdded = 0;
    //private float lookSensitivity = 3f;
    private PlayerMotor motor;
    
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        distanceTraveled = 0.0f;
        //new
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        Vector3 move = new Vector3(0, 0, speed);
        controller.Move(move * Time.deltaTime);
        //distanceTraveled += speed;
        //if(distanceTraveled >= 15000)
        {
            //Instantiate(roadPrefab, new Vector3(0, 0, EndPosLastRoad), Quaternion.identity);
            //GameObject* rdptr = &road;
            //roadObj.Add(road);
            //roadAdded++;
            //EndPosLastRoad += 300;

           // Debug.Log("Respawn road");
           // distanceTraveled = 0.0f;
            // float angle = i * Mathf.PI * 2 / numberOfObjects;
            // float x = Mathf.Cos(angle) * radius;
            // float z = Mathf.Sin(angle) * radius;
            // Vector3 pos = transform.position + new Vector3(x, 0, z);
            // float angleDegrees = -angle*Mathf.Rad2Deg;
            // Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            // Instantiate(prefab, pos, rot);
            // if(roadAdded > 2){
            //     roadObj.Remove(rdptr);
            //     roadAdded--;
            // }
            //Destroy(road, 5);
            //Destroy(roadObj[roadObj.Count-1], 2);
        }
        
       

        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // controller.LookAt(mousePos);

        // // look around

        // //Calculate rotation as a 3D vector (turning around)
		// float _yRot = Input.GetAxisRaw("Mouse X");

		// Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

		// //Apply rotation
		// motor.Rotate(_rotation);

		// //Calculate camera rotation as a 3D vector (turning around)
		// float _xRot = Input.GetAxisRaw("Mouse Y");

		// float _cameraRotationX = _xRot * lookSensitivity;
    }
}
