using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMOVE : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {


        rb.AddForce(5, 0, -17, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
