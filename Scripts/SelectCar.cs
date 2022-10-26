using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCar : MonoBehaviour
{
    public GameObject[] cars;
    static int index = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void resetIndex()
    {
        index = 1;
    }

    public void nextCar()
    {
        index = index + 1;
        if(index == 2)
        {
            foreach(GameObject car in cars)
            {
                car.SetActive(false);
            }
            cars[1].SetActive(true);
            options.setCar("blue");
        }
        else if(index == 3)
        {
            foreach (GameObject car in cars)
            {
                car.SetActive(false);
            }
            cars[2].SetActive(true);
            options.setCar("white");
        }
        else
        {
            index = 3;
        }
    }
    public void prevCar()
    {
        index = index - 1;
        if (index == 1)
        {
            foreach (GameObject car in cars)
            {
                car.SetActive(false);
            }
            cars[0].SetActive(true);
            options.setCar("black");
        }
        else if (index == 2)
        {
            foreach (GameObject car in cars)
            {
                car.SetActive(false);
            }
            cars[1].SetActive(true);
            options.setCar("blue");
        }
        
        else
        {
            index = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
