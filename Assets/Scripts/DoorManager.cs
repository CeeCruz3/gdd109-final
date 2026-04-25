using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject[] doors;

    public static void Toggle(GameObject[] doors)
    {
        foreach (GameObject door in doors)
        {
            if (door.activeSelf == true)
            {
                door.SetActive(false);
            }
            else
            {
                door.SetActive(true);
            }
        }
    }
}
