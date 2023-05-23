using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject[] _spawnPoints;
    [SerializeField] private int _spawnDelay;
    void Start()
    {
        InvokeRepeating("GenerateNum", 0, _spawnDelay);
    }
    void GenerateNum()
    {
        int num = Random.Range(0,_spawnPoints.Length);
        Spawn(num);
    }
    void Spawn(int num)
    {
        Instantiate(_enemy,_spawnPoints[num].transform);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
