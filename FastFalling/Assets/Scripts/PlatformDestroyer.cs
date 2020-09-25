using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Platform>() != null)
            Destroy(collision.gameObject);
    }
}
