using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecTOpponents : MonoBehaviour
{
    static int index = 1;
    public GameObject[] sprites;
    // Start is called before the first frame update
    
    public static void resetIndex()
    {
        index = 1;
    }
    public void increaseOpponents()
    {
        index = index + 1;
        
        if (index == 2)
        {
            foreach(GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[1].SetActive(true);
             
        }
        else if (index == 3)
        {
            foreach (GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[2].SetActive(true);
        }
        else if (index == 4)
        {
            foreach (GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[3].SetActive(true);
        }
        else
        {
            index = 4;
        }
    }
    public void decreaseOpponents()
    {
        index = index - 1;

        if (index == 2)
        {
            foreach (GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[1].SetActive(true);
        }
        else if (index == 3)
        {
            foreach (GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[2].SetActive(true);
        }
        else if (index == 1)
        {
            foreach (GameObject sprite in sprites)
            {
                sprite.SetActive(false);
            }
            sprites[0].SetActive(true);
        }
        else
        {
            index = 1;
        }
    }
}