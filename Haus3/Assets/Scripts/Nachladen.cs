using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nachladen : MonoBehaviour
{
    public GameObject NachladenUI;
    private bool anzeigen;

    private void Start()
    {
        anzeigen = GameObject.Find("Gun").GetComponent<Gun>().nachladen;
    }

    // Update is called once per frame
    void Update()
    {
        anzeigen = GameObject.Find("Gun").GetComponent<Gun>().nachladen;
        if (anzeigen)
        {
            NachladenUI.SetActive(true);
            return;
        }
        else
        {
            NachladenUI.SetActive(false);
        }
    }
}
