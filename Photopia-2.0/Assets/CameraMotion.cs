using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CameraMotion : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 20.0f;
    private float distanceTraveled; 
    public float EndPosLastRoad = 300; 
    public GameObject roadPrefab;
    
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
        distanceTraveled += speed;
        if(distanceTraveled >= 150000)
        {
            Instantiate(roadPrefab, new Vector3(0, 0, EndPosLastRoad), Quaternion.identity);

            EndPosLastRoad += 300;

            Debug.Log("Respawn road");
            distanceTraveled = 0.0f;


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
