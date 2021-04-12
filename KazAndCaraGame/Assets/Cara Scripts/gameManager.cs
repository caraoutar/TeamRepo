using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//used this YouTube video for help: https://www.youtube.com/watch?v=QbqnDbexrCw&ab_channel=AlexanderZotov

public class gameManager : MonoBehaviour
{

    //cranberry value set to public since we will be accessing it from player movement script
    //starts at 0 
    public static int CranberryValue = 0;
    //text variable for score
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        //accesses text component of ScoreText since we've attached this script to it
        score = GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
        //display cranberry value as player picks up cranberries
        score.text = " " + CranberryValue; 
        
    }
}
