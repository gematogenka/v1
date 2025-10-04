using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 300f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Движение влево-вправо по оси Y
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Speed * Time.deltaTime, 0, 0);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce);
        }
    }
}