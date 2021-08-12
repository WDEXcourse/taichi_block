//ボールを動かすスクリプト
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

    void OnCollisionStay(Collision hit)
    {
        Debug.Log(hit.gameObject.name);
        if (hit.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(-1.8f, -159f, 367.37f);

        }
      
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("45");
    }
}
