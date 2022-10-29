using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float movementSpeed = 5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        ReloadScene();
    }
    void ReloadScene()
    {
        if (transform.position.y <= -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}