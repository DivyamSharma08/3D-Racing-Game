using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 6f;
    public float height   = 3f;

    void Start()
    {
        FindPlayer();   
    }

    // Update is called once per frame
    void FindPlayer()
    {
        target = GameObject.Find(options.getcar()).transform;
    }
    void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position;
        transform.position = transform.position - target.rotation * Vector3.forward * distance;
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
        transform.LookAt(target);
    }

}
