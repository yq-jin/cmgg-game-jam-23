using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    //1 = white
    //2 = black
    //0 = empty
    public GameObject redChecker;
    public GameObject blackChecker;


    int[,] checkerboard = new int[8,8]
    {
        {0,1,0,1,0,1,0,1},
        {1,0,1,0,1,0,1,0},
        {0,1,0,1,0,1,0,1},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {2,0,2,0,2,0,2,0},
        {0,2,0,2,0,2,0,2},
        {2,0,2,0,2,0,2,0},
    };//this took a while to figure out because i don't use c#
    void Start()
    {
     for(int y=0;y<8;y++)
     {
        for(int x=0;x<8;x++)//temporary solutions let's optimzie this
        {
            //arrays are being a bad word so i'm doing this the cringe way
            //please optimize this (and tell unity to stop using C# please this langauge is sol balding)
            //why can't i put prefabs in an array??? (it is because we use object oriented hahahah please javascript save me)
            switch(checkerboard[y,x])
            {
                case 1:
                Instantiate(redChecker, new Vector2(x, y), Quaternion.identity);
                break;
                
                case 2:
                Instantiate(blackChecker, new Vector2(x, y), Quaternion.identity);
                break;

                default:
                break;
            }
        }
     }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
