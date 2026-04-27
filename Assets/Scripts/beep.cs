using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class beep : MonoBehaviour
{
    [SerializeField] private AudioSource unlock;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("beep") == 1)
        {
            unlock.Play();
            PlayerPrefs.SetInt("beep", 0);
        }
    }

 
}
