using UnityEngine;

public class TargetInteractable : MonoBehaviour
{
    public enum InteractableType
    {
        Collectable,
        Trap,
        Rotator
    }

    public InteractableType type;
    GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Trigger()
    {
        if (type == InteractableType.Collectable)
        {
            gameObject.SetActive(false);
        }
        else if (type == InteractableType.Trap)
        {
            
        }
        else if (type == InteractableType.Rotator)
        {
            
            Debug.Log("Hit Rotator! Rotation enabled.");
        }
        
    }
}
