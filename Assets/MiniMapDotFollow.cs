using UnityEngine;

public class MiniMapDotFollow : MonoBehaviour
{
    public Transform player; // Reference to the player

    void LateUpdate()
    {
        if (player != null)
        {
            // Match the position of the dot with the player
            transform.position = new Vector3(player.position.x, player.position.y, 0);
        }
    }
}
