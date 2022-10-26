using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public AudioSource sd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void LoadChooseCar()
    {
        SceneManager.LoadScene(1);
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void loadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        SelectCar.resetIndex();
        options.setCar("black");
    }
    public void loadOptions()
    {
        SceneManager.LoadScene(3);
    }
    public void loadquit()
    {
        Debug.Log("quit");
        Application.Quit();
        sd.Stop();
    }
}
