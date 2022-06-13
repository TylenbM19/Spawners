using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] private TheEnemy _enemy;
    private List<Transform> _positions = new List<Transform>();
    private float _timeRespawnEnemy = 2f;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _positions.Add(transform.GetChild(i));
        }
    }

    private void Start()
    {
        StartCoroutine(Respawm());
    }

    private IEnumerator Respawm()
    {
        for (int i = 0; i < _positions.Count; i++)
        {
            Instantiate(_enemy, _positions[i].position, _positions[i].rotation);
            yield return new WaitForSeconds(_timeRespawnEnemy);
        }
    }
}
