using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_ : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 20.0f;
    //private float distanceTraveled; 
    //public float EndPosLastRoad = 300; 
    //public GameObject roadPrefab;
    //public vector roadObj;
    //public List<GameObject> roadObj = new List<GameObject>();
    //private int roadAdded = 0;
    //private float lookSensitivity = 3f;
    //private PlayerMotor motor;
    public GameObject car;

    private void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();
        //distanceTraveled = 0.0f;
        //new
        //motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        Vector3 move = new Vector3(0, 0, speed);
        controller.Move(move * Time.deltaTime);
        //distanceTraveled += speed;
              
        //gameObject.lookAt(Vector3.forward);

    }
}
