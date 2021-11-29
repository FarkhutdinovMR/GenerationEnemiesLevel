using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, _repeatRate);
    }

    private void Spawn()
    {
        int index = Random.Range(0, _points.Length);

        Instantiate(_enemy, _points[index].position, Quaternion.identity);
    }
}