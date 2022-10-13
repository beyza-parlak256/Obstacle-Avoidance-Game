using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private float speedMovement;

    void Update()
    {
        float speed = speedMovement * Input.GetAxis("Horizontal");

        // X ekseninde yani yatay düzlemde hareket etmesini istiyoruz
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
