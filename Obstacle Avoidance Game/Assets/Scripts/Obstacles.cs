using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacles : MonoBehaviour
{

    private static int score;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        // int -> stringe geçiþte ToString() kullanýlýr
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter2D(Collision2D contact)
    {
        float xPosition = Random.Range(-7.5f, 8f);
        float yPosition = Random.Range(6f, 20f);

        if(contact.gameObject.tag == "ControlStick")
        {
            score += Random.Range(5,16);
            transform.position = new Vector2(xPosition,yPosition);
        }
        if(contact.gameObject.tag == "Character")
        {
            transform.position = new Vector2(xPosition, yPosition);
            Health.remainingHealth--;
        }
    }
    

}
