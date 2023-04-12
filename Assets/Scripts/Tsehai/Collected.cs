using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collected : MonoBehaviour
{
    public string Pname;
    bool inRange=false;
    public TextMeshProUGUI collect;
    public GameObject E;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true)
        {
            E.SetActive(true);
        } else
        {
            E.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }
    }
}
