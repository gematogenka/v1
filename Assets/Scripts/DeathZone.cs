using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, является ли объект, вошедший в триггер, игроком
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(0, 1, 0);
            Debug.Log("Игрок был телепортирован!");
        }
    }
}