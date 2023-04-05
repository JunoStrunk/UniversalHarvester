using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDelay : MonoBehaviour
{
    public MeshRenderer stage1;
    public MeshRenderer stage2;
    public MeshRenderer stage3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {

    }
}
