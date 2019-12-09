using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform thePlayer; //attached the transform of the player

    
    void Update()
    {
        this.transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, -10f);
        //the position of the camera which
    }
}
