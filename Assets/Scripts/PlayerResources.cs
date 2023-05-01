using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    public static int Gold;
    public int startingGold = 500;

    public static int Lives;
    public int startingLives = 10;

    void Start(){
        Gold = startingGold;
        Lives = startingLives;
        
    }
}
