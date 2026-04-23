using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChecker : MonoBehaviour
{
    [SerializeField] int level;
    // Start is called before the first frame update
    void Start()
    {
        switch (level)
        {
            case 2:
                if (PlayerPrefs.GetInt("Level 2") < 1)
                {
                    this.gameObject.GetComponent<Button>().interactable = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().interactable = true;
                }
                    break;
            case 3:
                if (PlayerPrefs.GetInt("Level 3") < 1)
                {
                    this.gameObject.GetComponent<Button>().interactable = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().interactable = true;
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("Level 4") < 1)
                {
                    this.gameObject.GetComponent<Button>().interactable = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().interactable = true;
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("Level 5") < 1)
                {
                    this.gameObject.GetComponent<Button>().interactable = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().interactable = true;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
