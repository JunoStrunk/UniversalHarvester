using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRange : MonoBehaviour
{
    //checks if in range of specific plot
    public static InRange instance;
    public bool inRange=false;


    // Start is called before the first frame update
     void Awake()
    {
        instance = this;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = false;
        }
    }
}
