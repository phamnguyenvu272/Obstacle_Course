using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer1;
    Rigidbody rigidbody1;
    [SerializeField] float dropTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        renderer1 = GetComponent<MeshRenderer>();
        rigidbody1 = GetComponent<Rigidbody>();

        renderer1.enabled = false;
        rigidbody1.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            renderer1.enabled = true;
            rigidbody1.useGravity = true;
        }
    }
}
