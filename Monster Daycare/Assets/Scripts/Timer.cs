using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] TextMeshProUGUI loseText;
    [SerializeField] float remainingTime;
    [HideInInspector] public bool gameOver = false;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        monster = FindObjectOfType<Monster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
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
            winText.enabled = true;
            winText.gameObject.SetActive(true);
        }

        if (monster.hearts == 0)
        {
            gameOver = true;
            loseText.enabled = true;
            loseText.gameObject.SetActive(true);
        }
    }
}
