using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text MeshPro yu kullan�yoruz
public class Health : MonoBehaviour
{
    public static int remainingHealth = 3; // kalan sa�l�k
    public TextMeshProUGUI healthText;
    public GameObject theEndPanel;
    void Update()
    {
        healthText.text = "Health:" + remainingHealth.ToString();

        if (remainingHealth == 0)
        {
            theEndPanel.SetActive(true); // biti� paneli aktif
            Time.timeScale = 0; // oyun durur
        }
    }
}
