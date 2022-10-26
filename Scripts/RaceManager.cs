using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour
{
    GameObject Player;
    GameObject[] AIs;
    AudioSource[] audiosources;
    CheckPoints checkpoint;
    public int maxLap = 1;
    public GameObject finishMenu;
    public GameObject UIScript;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        checkpoint = Player.GetComponent<CheckPoints>();
        AIs = GameObject.FindGameObjectsWithTag("AI");
    }

    // Update is called once per frame
    void Update()
    {
        if(checkpoint.lap > maxLap)
        StopCar(Player);
        foreach(GameObject AI in AIs)
        {
            if(AI.GetComponent<CheckPoints>().lap > maxLap)
            StopCar(AI);
        }
    }

    void StopCar(GameObject car)
    {
        car.GetComponent<CarController>().enabled = false;
        car.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        car.GetComponent<Rigidbody>().isKinematic = true;


        if (car.GetComponent<CarUserControl>() != null)
            car.GetComponent<CarUserControl>().enabled = false;

        if (car.GetComponent<resetCar>() != null)
            car.GetComponent<resetCar>().enabled = false;

        audiosources = car.GetComponents<AudioSource>();
        foreach (AudioSource audioSource in audiosources)
        {
            audioSource.enabled = false;
        }
        if (car.tag == "Player")
        {
            finishMenu.SetActive(true);
            UIScript.SendMessage("ShowfinalPos");
        }
    }

}
