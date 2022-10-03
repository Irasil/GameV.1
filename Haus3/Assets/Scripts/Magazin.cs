using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magazin : MonoBehaviour
{
    public Text counterText;
    public int counter;

    public void Update()
    {
        counter = GameObject.Find("Gun").GetComponent<Gun>().currentAmmo;
        counterText.text = counter.ToString();
    }
}
