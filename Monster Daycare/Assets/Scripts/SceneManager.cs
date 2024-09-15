using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        HowToPlay
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
    public void LoadTitle()
    {
        SceneManager.LoadScene(Scene.Title.ToString());
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(Scene.Game.ToString());
    }
    public void LoadHowToPlay()
    {
        SceneManager.LoadScene(Scene.HowToPlay.ToString());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
