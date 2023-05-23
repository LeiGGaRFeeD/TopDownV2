using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _firePlace;
    [SerializeField] private GameObject _bullet;
    void Start()
    {
        
    }
    public void Fire()
    {
        Instantiate(_bullet, _firePlace.transform);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
