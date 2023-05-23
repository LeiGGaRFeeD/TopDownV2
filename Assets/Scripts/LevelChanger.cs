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
    public void GoToLevelTwo()
    {
        Debug.Log("Go to level 2");
        SceneManager.LoadScene("LevelTwo");
    }
    public void GoToLevelThree()
    {
        Debug.Log("Go to level 3");
        SceneManager.LoadScene("LevelThree");
    }
    public void GoToLevelFour()
    {
        Debug.Log("Go to level 4");
        SceneManager.LoadScene("LevelFour");
    }
    public void GoToLevelFive()
    {
        Debug.Log("Go to level 5");
        SceneManager.LoadScene("LevelFive");
    }
    public void GoToLevelSix()
    {
        Debug.Log("Go to level 6");
        SceneManager.LoadScene("LevelSix");
    }
    public void GoToLevelMainMenu()
    {
        Debug.Log("Go to MainMenu");
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
