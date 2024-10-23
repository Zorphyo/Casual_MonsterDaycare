using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
    }
    public void UnPause()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
    }
}
