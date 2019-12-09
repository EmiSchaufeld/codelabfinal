using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int speed; //speed player moves
   
   void Update()
    {

        Movement(); // Player Movement 
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.W))//move up
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))//move down
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))//move left
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))//move right
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}