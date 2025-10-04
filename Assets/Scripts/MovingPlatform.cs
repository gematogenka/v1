using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float Speed = 1f;
    public float Distance = 2f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * Speed) * Distance;
        transform.position = startPosition + new Vector3(0, 0, movement);
    }
}