using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //public GameObject playerHealth;
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
        if (currentHealth < 50f && currentHealth > 20f)
        {
            Image.color = Color.yellow;
            Image.fillAmount = currentHealth / maxHealth;
        }
        else if (currentHealth <= 20f)
        {
            Image.color = Color.red;
            Image.fillAmount = currentHealth / maxHealth;
        }
    }

}
