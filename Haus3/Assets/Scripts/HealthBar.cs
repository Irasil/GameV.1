using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject playerHealth;
    private Image Image;

    private float currentHealth;
    private float maxHealth;

    public void Start()
    {
        maxHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health;
        Debug.Log(maxHealth);
        Image = GetComponent<Image>();
    }

    public void Update()
    {
        currentHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health;
        //Debug.Log(currentHealth / maxHealth);
        Image.fillAmount = currentHealth / maxHealth;
    }

}
