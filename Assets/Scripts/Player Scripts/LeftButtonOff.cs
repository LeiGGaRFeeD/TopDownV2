using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButtonOff : MonoBehaviour
{
    [SerializeField]private GameObject _button;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>() == true)
        {
            Debug.Log("Touch!");
            _button.GetComponent<Button>().enabled = false;
          //  Button.enabled = true;
          PlayerMovement.speedX = 0;
          _button.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>() == true)
        {
            // _button.SetActive(true);
          //  _button.interactable = true;
            _button.GetComponent<Button>().enabled = true;
            //  collision.set
            _button.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
