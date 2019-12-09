using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTime : MonoBehaviour
{
 
        public float time; //Seconds to read the text

        void Start()
        {
            Destroy(gameObject, time); //text will be destroyed after set time
        }
   
}
