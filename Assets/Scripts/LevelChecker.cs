using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChecker : MonoBehaviour
{
    [SerializeField] int level;

    public Sprite ButtonImage;
    public Sprite defaultButtonImage;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (level)
        {
            case 1:
                if(PlayerPrefs.GetInt("Level 1") > 1)
                {
                    this.gameObject.GetComponent<Button>().image.sprite = ButtonImage;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().image.sprite = defaultButtonImage;
                }
                    break;
            case 2:
                if (PlayerPrefs.GetInt("Level 2") < 1)
                {
                    this.gameObject.GetComponent<Button>().interactable = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().interactable = true;
                }

                if (PlayerPrefs.GetInt("Level 2") > 1)
                {
                    this.gameObject.GetComponent<Button>().image.sprite = ButtonImage;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().image.sprite = defaultButtonImage;
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

                if (PlayerPrefs.GetInt("Level 3") > 1)
                {
                    this.gameObject.GetComponent<Button>().image.sprite = ButtonImage;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().image.sprite = defaultButtonImage;
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

                if (PlayerPrefs.GetInt("Level 4") > 1)
                {
                    this.gameObject.GetComponent<Button>().image.sprite = ButtonImage;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().image.sprite = defaultButtonImage;
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

                if (PlayerPrefs.GetInt("Level 5") > 1)
                {
                    this.gameObject.GetComponent<Button>().image.sprite = ButtonImage;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().image.sprite = defaultButtonImage;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
