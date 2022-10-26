using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablecar : MonoBehaviour
{
    public GameObject black;
    public GameObject blue;
    public GameObject white;


    private void Awake()
    {
        if(options.getcar() == "black")
        {
            blue.SetActive(false);
            white.SetActive(false);
        }
        else if (options.getcar() == "blue")
        {
            black.SetActive(false);
            white.SetActive(false);
        }
        else if (options.getcar() == "white")
        {
            blue.SetActive(false);
            black.SetActive(false);
        }
    }
    void Start()
    {
        Invoke("EnableCalPos", 1);        
    }
    void EnableCalPos()
    {
        GameObject.Find(options.getcar()).GetComponent<CalculatePositions>().enabled = true;
    }

}
