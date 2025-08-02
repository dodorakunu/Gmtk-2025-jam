using UnityEngine;

public class LimitMovement : MonoBehaviour
{
    public float minX = -10f;
    public float maxX = 16f;
    public float minZ = -7f;
    public float maxZ = 25f;
    public float maxY = 6f;
    public float minY = 1.5f;

   

    void Update()
    {
        Vector3 newPosition = transform.position;

        // Clamp the position to stay within the defined limits
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        transform.position = newPosition;
    }
}
