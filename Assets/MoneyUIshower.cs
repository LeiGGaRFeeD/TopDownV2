using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUIshower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text _text;
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        _text.text = PlayerPrefs.GetInt("money").ToString();
    }
}
