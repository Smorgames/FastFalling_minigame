using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] [Header ("Spawn object settings")] private int _platformAmount;

    [SerializeField] private GameObject _platformPrefab;

    [SerializeField] [Header("Spawner limits")] private float _xSpawnLimit;

    [SerializeField] private float _yMinSpawnLimit;
    [SerializeField] private float _yMaxSpawnLimit;
    [SerializeField] private float _deltaIncreaseDistanceLimit;

    private Vector3 _spawnPosition;

    private void Start()
    {
        int countdowner = 0;

        while (countdowner < _platformAmount)
        {
            SpawnPlatforms();
            countdowner++;
        }
    }

    private void SpawnPlatforms()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-_xSpawnLimit, _xSpawnLimit),
        transform.position.y - Random.Range(_yMinSpawnLimit, _yMaxSpawnLimit), transform.position.z);

        Instantiate(_platformPrefab, spawnPosition, Quaternion.identity);

        transform.position = spawnPosition;

        _yMinSpawnLimit += _deltaIncreaseDistanceLimit;
        _yMaxSpawnLimit += _deltaIncreaseDistanceLimit;
    }
}
