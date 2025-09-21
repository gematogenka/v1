using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float bounceForce = 500f; // Переменная для настройки силы отскока

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {

            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            playerRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);

        }
    }
}