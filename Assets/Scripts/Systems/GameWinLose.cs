using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinLose : MonoBehaviour
{
    [SerializeField] private int _maxScore;
    [SerializeField] private int _levelCompleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Check()
    {
        if (PlayerPrefs.GetInt("money") < 0)
        {
            Debug.Log("You lose!");
            PlayerPrefs.SetInt("money", 0);
            SceneManager.LoadScene("LoseScene");
        }
        if (PlayerPrefs.GetInt("money") >= _maxScore)
        {
            Debug.Log("You win!");
            PlayerPrefs.SetInt("money", 0);
            PlayerPrefs.SetInt("level",_levelCompleted);
            SceneManager.LoadScene("WinScene");
        }
    }
    // Update is called once per frame
    void Update()
    {
        Check();
    }
}
