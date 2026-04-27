using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCheckFor5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("5Done") == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    
}
