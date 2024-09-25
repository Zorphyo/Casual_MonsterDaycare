using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Title,
        Game,
        Game2,
        HowToPlay,
        MainMenu,
        LevelSelect
    }

    public void LoadScene(Scene scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene.ToString());
    }
    public void LoadTitle()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.Title.ToString());
    }
    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.Game.ToString());
    }
    public void LoadGame2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.Game2.ToString());
    }
    public void LoadHowToPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.HowToPlay.ToString());
    }
    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.MainMenu.ToString());
    }
    public void LoadLevelSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.LevelSelect.ToString());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
