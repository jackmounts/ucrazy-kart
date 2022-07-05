using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform target = null;

    [SerializeField]
    [Range(0.1f, 1f)]
    private float smoothSpeed = 0.125f;

    [SerializeField]
    private Vector3 offset = new Vector3(0f, 2.6f, -6.5f);

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 diseredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, diseredPosition, ref velocity, smoothSpeed);
    }
}
