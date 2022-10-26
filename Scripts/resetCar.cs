using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCar : MonoBehaviour
{
    float elapseedtime = 0;
    CheckPoints checkpoints;
    Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkpoints = GetComponent<CheckPoints>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(rb.velocity.magnitude <= 1)
        {
            elapseedtime = elapseedtime + Time.deltaTime;
        }
        else
        {
            elapseedtime = 0;
        }
        if(elapseedtime > 5)
        {
            gameObject.transform.position = checkpoints.PrevCheckpoint.transform.position;
        }
    }
}
