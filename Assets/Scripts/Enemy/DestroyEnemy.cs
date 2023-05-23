using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] private float _destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DeletingEnemy", _destroyTime, 0);
    }
    void DeletingEnemy()
    {
        PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") - 200));
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
