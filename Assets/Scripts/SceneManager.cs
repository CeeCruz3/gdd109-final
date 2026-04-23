using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static void ToLevelSelect()
    {
        Debug.Log("Hi");
        SceneManager.LoadScene("Level Select");
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void ResetProg()
    {
        PlayerPrefs.SetInt("Level 1", 1);
        PlayerPrefs.SetInt("Level 2", 0);
        PlayerPrefs.SetInt("Level 3", 0);
        PlayerPrefs.SetInt("Level 4", 0);
        PlayerPrefs.SetInt("Level 5", 0);
    }

    public void ToLevel(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene("Level 1");
                break;
            case 2:
                SceneManager.LoadScene("Level 2");
                break;
            case 3:
                SceneManager.LoadScene("Level 3");
                break;
            case 4:
                SceneManager.LoadScene("Level 4");
                break;
            case 5:
                SceneManager.LoadScene("Level 5");
                break;
        }
    }

    public static void ClearLevel(int level)
    {
        switch (level)
        {
            case 1:
                PlayerPrefs.SetInt("Level 1", 2);
                break;
            case 2:
                PlayerPrefs.SetInt("Level 2", 2);
                PlayerPrefs.SetInt("Level 3", 1);
                break;
            case 3:
                PlayerPrefs.SetInt("Level 3", 2);
                PlayerPrefs.SetInt("Level 4", 1);
                break;
            case 4:
                PlayerPrefs.SetInt("Level 4", 2);
                PlayerPrefs.SetInt("Level 5", 1);
                break;
            case 5:
                PlayerPrefs.SetInt("Level 5", 2);
                break;

        }
    }
    public static void PassLevel()
    {
        PlayerPrefs.SetInt("Level 2", 1);
    }
}
