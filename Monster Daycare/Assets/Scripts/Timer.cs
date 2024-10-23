using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject loseText;
    [SerializeField] float remainingTime;
    [HideInInspector] public bool gameOver = false;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        monster = FindObjectOfType<Monster>();
        winText.SetActive(false);
        loseText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver && GameManager.gameStarted && !PauseManager.isPaused)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
        
            else
            {
                remainingTime = 0;
            }
        
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        }
    }

    void FixedUpdate()
    {
        if (remainingTime < 1)
        {
            gameOver = true;
            //winText.enabled = true;
            winText.SetActive(true);
        }

        if (monster.hearts == 0)
        {
            gameOver = true;
            //loseText.enabled = true;
            loseText.SetActive(true);
        }
    }
}
