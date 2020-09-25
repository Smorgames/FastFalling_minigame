using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject _pointAdder;

    private void Start()
    {
        Instantiate(_pointAdder, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
            GAME_MANAGER.instance.GameOver();
    }
}
