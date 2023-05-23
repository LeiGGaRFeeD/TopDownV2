using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BulletScript>() == true)
        {
            PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 100));
            Destroy(collision.gameObject);
            Debug.Log("Bullet!");
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
