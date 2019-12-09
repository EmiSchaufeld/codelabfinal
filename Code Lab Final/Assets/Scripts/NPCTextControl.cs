using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCTextControl : MonoBehaviour
{
    public Text characterSay;

  
      
    
    void OnTriggerStay2D(Collider2D collision)
    {
        print(collision); //what you walked into
        if (Input.GetKey(KeyCode.I))
        {
            GameObject other = collision.gameObject; //grab the gameobject we collided with

            Text npcText = other.GetComponent<Text>();  //grab their text

            characterSay.text = npcText.text; //the notepad text says their text
        }
        
    }
}
