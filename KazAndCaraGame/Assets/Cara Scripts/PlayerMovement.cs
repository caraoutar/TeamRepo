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

public GameObject bush;

public GameObject bush2;

public GameObject bush3;

public GameObject bush4; 
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {

            //making sure pressing mouse is working
            //Debug.Log("pressed mouse"); 
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

        //Debug.Log(nextPos);

        }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.name == "bush") {
            Debug.Log("triggered bush object");
            GameObject[] cranberries1 = GameObject.FindGameObjectsWithTag("Cranberry");
            foreach(GameObject cranberry1 in cranberries1) {
                GameObject.Destroy(cranberry1);
            }

        }

        if(other.gameObject.name == "bush2") {

            Debug.Log("triggered bush2");
            GameObject[] cranberries2 = GameObject.FindGameObjectsWithTag("Cranberry2");
            foreach(GameObject cranberry2 in cranberries2) {
                GameObject.Destroy(cranberry2);
            }
        }

        if(other.gameObject.name == "bush3") {

            Debug.Log("triggered bush3");
            GameObject[] cranberries3 = GameObject.FindGameObjectsWithTag("Cranberry3");
            foreach(GameObject cranberry3 in cranberries3) {
                GameObject.Destroy(cranberry3);
            }
        }

        if(other.gameObject.name == "bush4") {

            Debug.Log("triggered bush4");

            //https://answers.unity.com/questions/1143629/destroy-multiple-gameobjects-with-tag-c.html
            //used this forum page for code reference ^ to destroy multiple tagged objects
            GameObject[] cranberries4 = GameObject.FindGameObjectsWithTag("Cranberry4");
            foreach(GameObject cranberry4 in cranberries4) {
                GameObject.Destroy(cranberry4);
            }

            //Destroy(GameObject.FindWithTag("Cranberry4"));
        }

        

        
        }


    }

    

