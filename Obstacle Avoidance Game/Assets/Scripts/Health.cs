using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text MeshPro yu kullanýyoruz
public class Health : MonoBehaviour
{
    public static int remainingHealth = 3; // kalan saðlýk
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = "Health:" + remainingHealth.ToString();

        if (remainingHealth == 0)
        {
            Time.timeScale = 0; // oyun durur
        }
    }
}
