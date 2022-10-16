using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
  

    void OnCollisionEnter2D(Collision2D contact)
    {
        float xPosition = Random.Range(-7.5f, 8f);
        float yPosition = Random.Range(6f, 20f);

        if(contact.gameObject.tag == "ControlStick")
        {
            transform.position = new Vector2(xPosition,yPosition);
        }
    }

}
