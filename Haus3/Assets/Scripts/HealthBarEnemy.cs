using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Image;
    public GameObject enemy;

    private float currentHealth;
    private float maxHealth;

    public void Start()
    {
        maxHealth = enemy.GetComponent<Target>().health;
        Debug.Log(maxHealth);
        //Image = GameObject.Find("Forground").GetComponent<Image>();
    }

    public void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);

        currentHealth = enemy.GetComponent<Target>().health;
        Debug.Log(currentHealth);
        Image.fillAmount = currentHealth / maxHealth;
        if (currentHealth < 30f && currentHealth > 20f)
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
