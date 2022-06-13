using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    private List<Transform> _spawnPoints = new List<Transform>();
    private WaitForSeconds _waitForSeconds = new WaitForSeconds(2f);

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _spawnPoints.Add(transform.GetChild(i));
        }
    }

    private void Start()
    {
        StartCoroutine(Respawm());
    }

    private IEnumerator Respawm()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Instantiate(_enemy, _spawnPoints[i].position, _spawnPoints[i].rotation);
            yield return _waitForSeconds;
        }
    }
}
