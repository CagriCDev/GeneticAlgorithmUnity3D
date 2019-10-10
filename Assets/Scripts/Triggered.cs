using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour
{
    public static int succesGens;
    // Start is called before the first frame update
    void Start()
    {
        succesGens = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            succesGens++;
            Debug.Log(succesGens);
            
        }
    }

}
