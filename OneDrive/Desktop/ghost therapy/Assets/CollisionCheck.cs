using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    bool graveOne = false;
    bool graveTwo = false;
    bool graveThree = false;
    bool graveFour = false;
    public bool openGate = false;

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name); // any collision

        //Debug.Log("hey this is" + col.name);

        if (collision.gameObject.name == "grave1")
        { // collision w a specific tomb
            graveOne = true;
            Debug.Log(graveOne);
        }
        else if (collision.gameObject.name == "grave2")
        {
            graveTwo = true;
            Debug.Log(graveTwo);
        }
        else if (collision.gameObject.name == "grave3")
        {
            graveThree = true;
            Debug.Log(graveThree);
        }
        else if (collision.gameObject.name == "grave4")
        {
            graveFour = true;
            Debug.Log(graveFour);
        }

    }

    private void Update()
    {
        if (graveOne && graveTwo && graveThree && graveFour)
        {
            openGate = true;
        }
    }
}
