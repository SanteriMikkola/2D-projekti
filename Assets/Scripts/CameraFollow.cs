
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    private float moveSpeed;
    public Transform target;
    public Transform RespawnPoint;
    public Transform Camera;
    
    void Update()
    {
        moveSpeed = target.transform.position.x;
        Vector3 newPosition = new Vector3(target.position.x, 0f, 0);
        transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
        if (target.position == RespawnPoint.position)
        {
            Camera.transform.position = new Vector3(0, 0, 0);
            transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
        }
    }
}
