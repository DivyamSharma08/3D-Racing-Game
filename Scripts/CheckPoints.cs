using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CheckPoints : MonoBehaviour
{
    [HideInInspector]
    public int lap = 0;
    [HideInInspector]
    public int checkPoint = -1;
    int checkPointCount;
    int nextCheckpoint = 0;
    Dictionary<int, bool> visited = new Dictionary<int, bool>();
    public Text Laptest;
    [HideInInspector]
    public bool missed = false;
    public GameObject PrevCheckpoint;

    public float timehit;

    void Start()
    {
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("CheckPoints");
        checkPointCount = checkpoints.Length ;
        foreach(GameObject checpoint in checkpoints)
        {
            if(checpoint.name == "0")
            {
                PrevCheckpoint = checpoint;
                break;
            }
        }

        foreach(GameObject cp in checkpoints)
        {
            visited.Add(Int32.Parse(cp.name), false);
        }
        
    }


    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "CheckPoints")
        {
            int checkpointCurrent = int.Parse(col.gameObject.name);

            if(checkpointCurrent == nextCheckpoint)
            {
                timehit = Time.time;
                PrevCheckpoint = col.gameObject;
                visited[checkpointCurrent] = true;
                checkPoint = checkpointCurrent;
                if(checkPoint == 0)
                {
                    lap++;
                }
                
                nextCheckpoint++;
                if(nextCheckpoint >= checkPointCount)
                {
                    var keys = new List<int>(visited.Keys);
                    foreach(int key in keys)
                    {
                        visited[key] = false;
                    }
                    nextCheckpoint = 0;
                }
            }
            else if(checkpointCurrent != nextCheckpoint && visited[checkpointCurrent] == false)
            {
                missed = true;
            }
        }
    }
}
