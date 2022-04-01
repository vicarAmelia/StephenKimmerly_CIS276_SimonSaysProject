using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public string gameSceneName;
    // Start is called before the first frame update
    private void Start()
    {
       startButton.onClick.AddListener(LoadGameScene);
       exitButton.onClick.AddListener(ExitGame); 
    }

    public void LoadGameScene()
    {
        GameSceneManager.Instance.LoadScene(gameSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
