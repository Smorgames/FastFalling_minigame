using UnityEngine;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool _isClicked = false;

    [SerializeField] private Vector3 _direction;

    [SerializeField] private GameObject _player;
    private PlayerController _playerController;

    private void Start()
    {
        _playerController = _player.GetComponent<PlayerController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isClicked = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isClicked = false;
    }

    private void Update()
    {
        if (_isClicked)
            _playerController.MovePlayer(_direction);
    }
}
