using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed; //Speed of movement.
    public enum directionState{ //tracks which direction player is going
        up,
        down,
        left,
        right,
        none 
    }
    
    public directionState currentState = directionState.none; //Current state is none
    public SpriteRenderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Ran");
    }

    // Update is called once per frame
    void Update()
    {
        CheckKey(); //Calling check key function
        MoveMe(); //Calling movement function
    }

//This function checks what key is pressed + changes player's move state
    void CheckKey(){ 
        if (Input.GetKey (KeyCode.W)) { //Up 
            currentState = directionState.up;
        } else if (Input.GetKey (KeyCode.S)) { //Down
            currentState = directionState.down;
        } else if (Input.GetKey (KeyCode.A)) { //Left
            currentState = directionState.left;
            myRenderer.flipX = false;
        } else if (Input.GetKey (KeyCode.D)) { //Right
            currentState = directionState.right;
            myRenderer.flipX = true;
        } else {
            currentState = directionState.none; //None
        }
    }

//This function checks what movement state we're in and moves in that direction
    void MoveMe(){ 
        switch(currentState){
            case directionState.up:
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                Debug.Log("W key pressed");
                break;
            case directionState.down:
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                Debug.Log("S key pressed");
                break;
            case directionState.left:
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                Debug.Log("A key pressed");
                break;
            case directionState.right:
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                Debug.Log("D key pressed");
                break;
            default:
                Debug.Log("No key pressed");
                break;
        }
    }
}
