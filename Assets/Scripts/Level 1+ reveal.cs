using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Reveal : MonoBehaviour
{
    [SerializeField] private Sprite spook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("5Done") == 1 && PlayerPrefs.GetInt("Can Reset") != 1)
        {
            this.gameObject.GetComponent<Button>().image.sprite = spook;
        }
    }
}
