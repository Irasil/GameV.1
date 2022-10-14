
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
            Head();
        }

    }   

    public void Head()
    {     
        
        Destroy(target.transform.parent.gameObject);       
        
    }
}
