using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private bool isInitialized = false;

    private void Start()
    {
        // Находим игрока и сохраняем его начальное положение
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            initialPosition = player.transform.position;
            initialRotation = player.transform.rotation;
            isInitialized = true;
            Debug.Log("Начальная позиция сохранена: " + initialPosition);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, является ли объект, вошедший в триггер, игроком
        if (other.CompareTag("Player") && isInitialized)
        {
            // Телепортируем игрока в начальную позицию
            other.transform.position = initialPosition;
            other.transform.rotation = initialRotation;

            // Останавливаем движение (если есть Rigidbody)
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Игрок возвращен в начальную позицию!");
        }
    }
}