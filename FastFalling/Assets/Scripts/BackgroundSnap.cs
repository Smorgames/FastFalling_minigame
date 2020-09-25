using UnityEngine;

public class BackgroundSnap : MonoBehaviour
{
    [SerializeField] private Transform _snapTarget;
    [SerializeField] private float _snapCoordinate;
    [SerializeField] private Transform _camera;

    private void Update()
    {
        if (_camera.position.y - _snapCoordinate < transform.position.y)
            transform.position = new Vector3(transform.position.x, _snapTarget.position.y + _snapCoordinate, transform.position.z);
    }
}
