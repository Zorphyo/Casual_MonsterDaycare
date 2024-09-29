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
        BaseDaycare,
        HowToPlay,
        MainMenu,
        LevelSelect,
        Extras,
        Shop
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
    public void LoadBaseDaycare()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.BaseDaycare.ToString());
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
    public void LoadExtras()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.Extras.ToString());
    }
    public void LoadShop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene.Shop.ToString());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
