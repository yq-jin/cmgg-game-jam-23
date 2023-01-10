using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBoard : MonoBehaviour
{
    //1 = white
    //2 = black
    //0 = empty
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
