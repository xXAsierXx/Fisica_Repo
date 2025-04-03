using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;
    public bool randomize = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb = GetComponent<Rigidbody>();

            if (randomize)
            {
                int randomDirection = Random.Range(0, 4);
                switch (randomDirection)
                {
                    case 0:
                        rb.AddForce(Vector3.up * forceAmount);
                        Debug.Log("Applied UP force");
                        break;
                    case 1:
                        rb.AddForce(Vector3.down * forceAmount);
                        Debug.Log("Applied UP force");
                        break;
                    case 2:
                        rb.AddForce(Vector3.forward * forceAmount);
                        Debug.Log("Applied FORWARD force");
                        break;
                    case 3:
                        rb.AddForce(Vector3.back * forceAmount);
                        Debug.Log("Applied BACK force");
                        break;

                }
            } else
            {
                rb.AddForce(Vector3.up * forceAmount);
                Debug.Log("Applied UP force");
            }
        }
    }
}
