using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

//mouse movement code from class lecture

//movement vars

public float speed;

private Vector3 nextPos;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {

            //making sure pressing mouse is working
            Debug.Log("pressed mouse"); 
            //call movement function
            StartMovement();
        }
    }

    void StartMovement() {
        //set next position to where the player clicks on screen
        nextPos = Input.mousePosition;

        }


    }

