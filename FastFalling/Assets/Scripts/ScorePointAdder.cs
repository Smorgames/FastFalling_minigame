using UnityEngine;

public class ScorePointAdder : MonoBehaviour
{
    [SerializeField] private int _pointAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
            GAME_MANAGER.instance.AddScore(_pointAmount);
            Destroy(gameObject);
        }
    }
}
