using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        Instantiate(_enemy,transform);
    }
}
