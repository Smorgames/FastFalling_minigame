using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _horizontalMoveLimit;

    private Vector3 _movement;
    private Rigidbody2D _rigidBody;

    private Vector2 _playerPosition;

    private Vector2 _turnRight = new Vector3(1f, 1f, 1f);
    private Vector2 _turnLeft = new Vector3(-1f, 1f, 1f);

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");

        MovePlayer();

        PositionClamp();

        Turn();
    }

    private void PositionClamp()
    {
        _playerPosition = transform.position;

        _playerPosition.x = Mathf.Clamp(transform.position.x, -_horizontalMoveLimit, _horizontalMoveLimit);
        _playerPosition.y = transform.position.y;

        transform.position = _playerPosition;
    }

    private void MovePlayer()
    {
        transform.position += _movement * _moveSpeed * Time.deltaTime;
    }

    public void MovePlayer(Vector3 direction)
    {
        transform.position += direction * _moveSpeed * Time.deltaTime;
    }

    private void Turn()
    {
        if (_movement.x > 0)
            transform.localScale = _turnRight;
        if (_movement.x < 0)
            transform.localScale = _turnLeft;
    }
}
