using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetToggle : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Can Reset") != 0)
        {
            this.gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            this.gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
