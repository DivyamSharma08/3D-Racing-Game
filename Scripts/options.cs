using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour
{
    static string mycar = "black";
    static int AICarsCount = 1;

    public static void setCar(string car)
    {
        mycar = car;
    }
    public static string getcar()
    {
        return mycar;
    }
}
