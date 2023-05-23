using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoToLevelSelect()
    {
        Debug.Log("Go to level selection");
        SceneManager.LoadScene("LevelSelect");
    }
    public void GoToLevelOne()
    {
        Debug.Log("Go to level 1");
        SceneManager.LoadScene("LevelOne");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
