using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycount : MonoBehaviour
{
    private int count;
    public GameObject won;
    public GameObject wald;
    public GameObject magazin;

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("enemy").Length;
        //Debug.Log(count);
        Win();
    }

    public void Win()
    {
        if (count <= 0) {
            // Debug.Log("gewonnen");

            wald.SetActive(false);
            magazin.SetActive(false);
            won.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            //Destroy(gameObject);

            //MonoBehaviour[] scripts = gameObject.GetComponents<MonoBehaviour>();
            //foreach (MonoBehaviour script in scripts)
            //{
            //    script.enabled = false;
            //}
        }
    }
}
