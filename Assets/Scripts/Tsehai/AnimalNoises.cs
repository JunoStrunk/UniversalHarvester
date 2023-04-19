using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalNoises : MonoBehaviour
{
    public AudioClip[] noises;
    public AudioSource source;
    public bool isPlaying;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == false)
        {
            
            int n = Random.Range(3, 7);

            int num = Random.Range(0, noises.Length);
            source.clip = noises[num];
            source.Play();
            isPlaying = true;
            StartCoroutine(Wait(n));
            
        }
      
    }

   

    IEnumerator Wait(int wt)
    {
        yield return new WaitForSeconds(wt);
        isPlaying = false;
    }
}
