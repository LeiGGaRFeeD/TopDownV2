using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLevels : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] _levels;
    void Start()
    {
            for (int i = 0; i < _levels.Length; i++)
            {
                _levels[i].SetActive(false);
            }
    }
    void LevelOpener()
    {
        if (PlayerPrefs.GetInt("level") == 2){
            for (int i = 0; i < 2; i++)
            {
                _levels[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("level") == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                _levels[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("level") == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                _levels[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("level") == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                _levels[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("level") == 6)
        {
            for (int i = 0; i < 6; i++)
            {
                _levels[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("level") == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                _levels[i].SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("level") == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                _levels[i].SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        LevelOpener();
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerPrefs.SetInt("level", 0);
        }
    }
}
