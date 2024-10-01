using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI taskTimerText;
    [SerializeField] TextMeshProUGUI taskText;
    //private float taskTimer;
    public float timeForTask;
    [HideInInspector] public bool isTaskActive = false;

    public Image heart1;
    public Image heart2;
    public Image heart3;
    [HideInInspector] public int hearts = 3;

    PlayerMovement player;
    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        timer = FindObjectOfType<Timer>();

        InvokeRepeating("CreateTask", 5.0f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTaskActive)
        {
            taskTimerText.enabled = true;
            taskTimerText.gameObject.SetActive(true);

            taskText.enabled = true;
            taskText.gameObject.SetActive(true);

            if (timeForTask > 0)
            {
                timeForTask -= Time.deltaTime;
            }

            else
            {
                timeForTask = 0;
                taskTimerText.enabled = false;
                taskTimerText.gameObject.SetActive(false);

                taskText.enabled = false;
                taskText.gameObject.SetActive(false);

                if (hearts == 3)
                {
                    heart3.enabled = false;
                    heart3.gameObject.SetActive(false);
                }

                else if (hearts == 2)
                {
                    heart2.enabled = false;
                    heart2.gameObject.SetActive(false);
                }

                else 
                {
                    heart1.enabled = false;
                    heart1.gameObject.SetActive(false);
                    timer.gameOver = true;
                }

                hearts--;
                isTaskActive = false;
                timeForTask = 10.0f;
            }

            int seconds = Mathf.FloorToInt(timeForTask % 60);
            taskTimerText.text = string.Format("{0:0}", seconds); 
        }

        else 
        {
            taskTimerText.enabled = false;
            taskTimerText.gameObject.SetActive(false);

            taskText.enabled = true;
            taskText.gameObject.SetActive(false);
        }

        if (timer.gameOver)
        {
            isTaskActive = false;
            CancelInvoke();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(isTaskActive && player.hasItem == true)
        {
            player.GiveItem();
            isTaskActive = false;

            timeForTask = 10.0f;
            taskTimerText.enabled = false;
            taskTimerText.gameObject.SetActive(false);

            taskText.enabled = false;
            taskText.gameObject.SetActive(false);
        }
    }

    void CreateTask()
    {
        isTaskActive = true;
    }
}
