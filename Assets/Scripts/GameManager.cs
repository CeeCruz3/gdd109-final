using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int remainingTargets = 10;

    void Start()
    {
        Debug.Log("Targets remaining = " + remainingTargets);
    }

    public void TargetCollected()
    {
        remainingTargets -= 1;
        Debug.Log("Targets remaining = " + remainingTargets);

        if (remainingTargets <= 0)
        {
            Debug.Log("ALL TARGETS COLLECTED! Level Complete!");
            // put win UI / next level code here
        }
    }


}
