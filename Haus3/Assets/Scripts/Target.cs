
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject target;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

    }

     void Die()
    {
        Destroy(target);
    }

    public void Head()
    {
        
        
            Destroy(target);
        
    }
}
