using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player") //I choosed enemy as the custom tag
        {
            //Debug.Log("lol");
            PlayerMovement playerController = collision.gameObject.GetComponent<PlayerMovement>();
            Destroy(gameObject);
            playerController.TakeDamage(damage);
        }
    }
}

