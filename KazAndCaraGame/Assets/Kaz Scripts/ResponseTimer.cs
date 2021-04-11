using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseTimer : MonoBehaviour
{
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 3f; //setting timer
    }

    // Update is called once per frame
    void Update()
    {
    
    if (timer > 0){ //Timer is above zero seconds
        timer -= Time.deltaTime; //timer counts down
    }
    
    if(timer <= 0){ //Once timer reaches zero
        timer = 0; //cant go below zero
        Object.Destroy(this.gameObject); //Delete itself
        }
    }
    
}
