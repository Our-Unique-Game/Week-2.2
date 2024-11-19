using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player; // Reference to the player

    void LateUpdate()
    {
        // Make the mini-map camera follow the player's position
        if (player != null)
        {
            Vector3 newPosition = player.position;
            newPosition.z = transform.position.z; // Keep the camera's Z position fixed
            transform.position = newPosition;
        }
    }
}
