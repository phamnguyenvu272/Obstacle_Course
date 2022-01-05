using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" &&
            collision.gameObject.tag  != "Plane" &&
            collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into things this many times: " + hits);
            //Debug.Log(collision.gameObject.name);
        }
    }
}
