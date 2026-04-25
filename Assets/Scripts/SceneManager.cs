using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static void ToLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public static void ToTitle()
    {
        if (PlayerPrefs.GetInt("Levels Completed") == 5)
        {
            Debug.Log("You can reset now gg");
            PlayerPrefs.SetInt("Can Reset", 1);
        }
        Debug.Log(PlayerPrefs.GetInt("Can Reset"));
        SceneManager.LoadScene("Title");

    }

    public void ResetProg()
    {
        PlayerPrefs.SetInt("Level 1", 1);
        PlayerPrefs.SetInt("Level 2", 0);
        PlayerPrefs.SetInt("Level 3", 0);
        PlayerPrefs.SetInt("Level 4", 0);
        PlayerPrefs.SetInt("Level 5", 0);
        PlayerPrefs.SetInt("5Done", 0);
        PlayerPrefs.SetInt("Can Reset", 0);
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
                if(PlayerPrefs.GetInt("Level 1") != 2)
                {
                    PlayerPrefs.SetInt("Level 1", 2);
                    PlayerPrefs.SetInt("Can Reset", 1);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("Level 2") == 1)
                {
                    PlayerPrefs.SetInt("Level 2", 2);
                    PlayerPrefs.SetInt("Level 3", 1);
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("Level 3") == 1)
                {
                    

                    PlayerPrefs.SetInt("Level 3", 2);
                    PlayerPrefs.SetInt("Level 4", 1);
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("Level 4") == 1)
                {
                    PlayerPrefs.SetInt("Level 4", 2);
                    PlayerPrefs.SetInt("Level 5", 1);
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("Level 5") == 1)
                {
                    PlayerPrefs.SetInt("Level 5", 1);
                    PlayerPrefs.SetInt("5Done", 1);
                }
                break;

        }
    }
    public static void PassLevel()
    {
        if (PlayerPrefs.GetInt("Level 2") < 1)
        {
            PlayerPrefs.SetInt("Level 2", 1);
        }
    }
}
