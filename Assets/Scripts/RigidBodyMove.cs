using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class RigidbodyMoveWithInteractablesAndManager : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5f;
    [SerializeField] float accel = 12f;
    [SerializeField] float decel = 16f;

    [SerializeField] int level;
    [SerializeField] private AudioSource unlock;

    [SerializeField] GameObject[] doors;

    Vector2 currentVelocity;
    Rigidbody2D rb;

    float moveX;
    float moveY;
    private Vector3 startPos= new Vector3(-6f, 0f, 0f);

    void Awake()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 dir = new Vector2(moveX, moveY);
        Vector2 targetVelocity = dir * maxSpeed;

        float rate = (dir.sqrMagnitude > 0f) ? accel : decel;

        currentVelocity = Vector2.MoveTowards(
            currentVelocity,
            targetVelocity,
            rate * Time.fixedDeltaTime
        );

        rb.velocity = currentVelocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case("LevelGoal"):
                ChangeScene.ClearLevel(level);
                if(level == 1) { ChangeScene.ToTitle(); }
                else { ChangeScene.ToLevelSelect(); }
                break;
            case ("LevelPass"):
                ChangeScene.PassLevel();
                ChangeScene.ToLevelSelect();
                break;
            case ("KillZone"):
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
            case ("Key"):
                other.gameObject.SetActive(false);
                DoorManager.Toggle(doors);
                unlock.Play();
                break;
        }
    }
}
