using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CalculatePositions : MonoBehaviour
{
    struct Playerpositions
    {
        public int position;
        public float time;
        public Playerpositions(int p, float t)
        {
            position = p;
            time = t;
        }
    }
    CheckPoints checkpoints;
    static Dictionary<string, Playerpositions> positions = new Dictionary<string, Playerpositions>();

    GameObject player;
    string name;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        name = player.name;
        if(positions.ContainsKey(name) == false)
        {
            positions.Add(name, new Playerpositions(0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(checkpoints == null)
        {
            checkpoints = GetComponent<CheckPoints>();
        }
        SetPositions(name, checkpoints.lap, checkpoints.checkPoint, checkpoints.timehit);

        if(name == "Car")
        {
            string position = getPositions(name);
            Debug.Log(position);
        }



    }
    public static void SetPositions(string name, int lap, int checkpoint, float time)
    {
        int position = lap*10 + checkpoint;
        positions[name] = new Playerpositions(position, time);
    }
    public static string getPositions(string name)
    {
        int index = 0;
        foreach(KeyValuePair<string,Playerpositions> pos in positions.OrderByDescending(Key => Key.Value.position).ThenBy(key => key.Value.time))
        {
            index++;
            if(pos.Key == name)
            {
                switch(index)
                {
                    case 1: return "1";
                    case 2: return "2";
                    case 3: return "3";
                }
            }
        }
        return "unknown";
    }

}
