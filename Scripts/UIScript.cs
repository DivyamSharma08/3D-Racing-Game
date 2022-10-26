using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
    GameObject Player;
    public  GameObject MissedCheckPointText;
    public GameObject pauseGameMenu;
    public  Text posTest;
    public  Text lapTest;
    public  Text finalPos;
    CheckPoints checkpoint;



    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        checkpoint = Player.GetComponent<CheckPoints>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkpoint.checkPoint == 0 )
        {
            lapTest.GetComponent<Text>().text = "LAP: " + checkpoint.lap;
        }

        posTest.GetComponent<Text>().text = "POS: " + CalculatePositions.getPositions(Player.name);

        if(Player.GetComponent<CheckPoints>().missed == true)
        {
            StartCoroutine(ShowmissedCheckPointText());
            Player.GetComponent<CheckPoints>().missed = false;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGameMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    IEnumerator ShowmissedCheckPointText()
    {
        MissedCheckPointText.SetActive(true);
        yield return new WaitForSeconds(2);
        MissedCheckPointText.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseGameMenu.SetActive(false);

    }

    public void ShowfinalPos()
    {
        finalPos.text = "Position:" + CalculatePositions.getPositions(Player.name);
    }
}
