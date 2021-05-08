using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //This will make possiblу to save in a file.
public class PlayerData
{
    //No need to inherit from MonoBehavior


    public int level;

    public int health;

    public float[] position;

    /*
    public PlayerData(Player player)
    {
        level = player.level;

        health = player.health;


        position = new float[3]; //X/Y/Z
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;


        //Same way for Color: 4 elements - R/G/B + Alpha

    }
    */
}
