using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

//mouse movement code from class lecture

//movement vars

public float speed;

private Vector3 nextPos;

private bool reachedPos = true;

private bool stopMovement = false;
   

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
        //if reached pos is false
        if(!reachedPos) {

            //three parameters: where player is, where player wants to go, speed
            transform.position = Vector2.MoveTowards(transform.position, nextPos, speed);
            //did we get to next position (distance function)
            if(Vector3.Distance(transform.position, nextPos) <= 1f){
                reachedPos = true;

            }

        }
    }

    void StartMovement() {
        //set next position to where the player clicks on screen
        nextPos = Input.mousePosition;
        //assessing our camera, using the function (screen to world point) to use pixels of the world number
        //so that coordinates make sense for our screen
        nextPos = Camera.main.ScreenToWorldPoint(nextPos);

        //keep next Pos z value to same depth as player object 
        nextPos.z = 0;

        //is the position where we want to move to
        reachedPos = false;

        Debug.Log(nextPos);

        }


    }

