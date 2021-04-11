using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftResponse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GOOD;
    public GameObject BAD;
    public GameObject OK;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "Good Gift" && GameObject.FindGameObjectWithTag("response") == null){
        Instantiate(GOOD, new Vector3(3.07F, 0.6F, 0), Quaternion.identity);
        Object.Destroy(other.gameObject);
        } else if (other.gameObject.name == "OK Gift" && GameObject.FindGameObjectWithTag("response") == null){
        Instantiate(OK, new Vector3(3.07F, 0.6F, 0), Quaternion.identity);
        Object.Destroy(other.gameObject);
        } else if (other.gameObject.name == "Bad Gift" && GameObject.FindGameObjectWithTag("response") == null){
        Instantiate(BAD, new Vector3(3.07F, 0.6F, 0), Quaternion.identity);
        Object.Destroy(other.gameObject);
        }
    }
}
