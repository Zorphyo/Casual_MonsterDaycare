using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI taskTimer1Text;
    [SerializeField] TextMeshProUGUI taskTimer2Text;
    [SerializeField] TextMeshProUGUI taskTimer3Text;
    [SerializeField] Image task1Timer;
    [SerializeField] Image task2Timer;
    [SerializeField] Image task3Timer;
    [SerializeField] TextMeshProUGUI task1Text;
    [SerializeField] TextMeshProUGUI task2Text;
    [SerializeField] TextMeshProUGUI task3Text;

    SkinnedMeshRenderer mesh;
    [SerializeField] SkinnedMeshRenderer middleBaby;
    [SerializeField] SkinnedMeshRenderer finalBaby;

    float timeForTask1, timeForTask2, timeForTask3;
    float holdingTimeForTask;
    [HideInInspector] public bool isTask1Active = false;
    [HideInInspector] public bool isTask2Active = false;
    [HideInInspector] public bool isTask3Active = false;

    public List<string> itemNames;
    string task1Item, task2Item, task3Item;

    int random;
    int minTime, maxTime;

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
        mesh = GetComponent<SkinnedMeshRenderer>();

        if (SceneManager.difficulty == "Easy")
        {
            minTime = 12;
            maxTime = 15;
            holdingTimeForTask = 40.0f;
        }

        else 
        {
            minTime = 7;
            maxTime = 10;
            holdingTimeForTask = 10.0f;
        }

        timeForTask1 = holdingTimeForTask;
        timeForTask2 = holdingTimeForTask;
        timeForTask3 = holdingTimeForTask;

        random = Random.Range(minTime, maxTime);

        InvokeRepeating("CreateTask", 7.0f, random);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTask1Active)
        {
            taskTimer1Text.enabled = true;
            taskTimer1Text.gameObject.SetActive(true);

            task1Text.text = "1. Get " + task1Item;

            if (timeForTask1 > 1)
            {
                timeForTask1 -= Time.deltaTime;
            }

            else
            {
                timeForTask1 = 0;
                taskTimer1Text.enabled = false;
                taskTimer1Text.gameObject.SetActive(false);

                task1Text.text = "1. ";

                if (hearts == 3)
                {
                    heart3.enabled = false;
                    heart3.gameObject.SetActive(false);

                    mesh.sharedMesh = middleBaby.sharedMesh;
                    Material[] newMaterials = new Material[middleBaby.sharedMaterials.Length];
                    
                    for (int i = 0; i < middleBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = middleBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else if (hearts == 2)
                {
                    heart2.enabled = false;
                    heart2.gameObject.SetActive(false);

                    mesh.sharedMesh = finalBaby.sharedMesh;
                    Material[] newMaterials = new Material[finalBaby.sharedMaterials.Length];

                    for (int i = 0; i < finalBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = finalBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else 
                {
                    heart1.enabled = false;
                    heart1.gameObject.SetActive(false);
                    timer.gameOver = true;
                }

                hearts--;
                isTask1Active = false;
                timeForTask1 = holdingTimeForTask;
            }

            int seconds = Mathf.FloorToInt(timeForTask1 % 60);
            taskTimer1Text.text = string.Format("{0:0}", seconds);
            task1Timer.fillAmount = Mathf.InverseLerp(1, holdingTimeForTask, timeForTask1); 
        }

        else 
        {
            taskTimer1Text.enabled = false;
            taskTimer1Text.gameObject.SetActive(false);

            task1Text.text = "1. ";
        }

        if (isTask2Active)
        {
            taskTimer2Text.enabled = true;
            taskTimer2Text.gameObject.SetActive(true);

            task2Text.text = "2. Get " + task2Item;

            if (timeForTask2 > 1)
            {
                timeForTask2 -= Time.deltaTime;
            }

            else
            {
                timeForTask2 = 0;
                taskTimer2Text.enabled = false;
                taskTimer2Text.gameObject.SetActive(false);

                task2Text.text = "2. ";

                if (hearts == 3)
                {
                    heart3.enabled = false;
                    heart3.gameObject.SetActive(false);

                    mesh.sharedMesh = middleBaby.sharedMesh;
                    Material[] newMaterials = new Material[middleBaby.sharedMaterials.Length];
                    
                    for (int i = 0; i < middleBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = middleBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else if (hearts == 2)
                {
                    heart2.enabled = false;
                    heart2.gameObject.SetActive(false);

                    mesh.sharedMesh = finalBaby.sharedMesh;
                    Material[] newMaterials = new Material[finalBaby.sharedMaterials.Length];

                    for (int i = 0; i < finalBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = finalBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else 
                {
                    heart1.enabled = false;
                    heart1.gameObject.SetActive(false);
                    timer.gameOver = true;
                }

                hearts--;
                isTask2Active = false;
                timeForTask2 = holdingTimeForTask;
            }

            int seconds = Mathf.FloorToInt(timeForTask2 % 60);
            taskTimer2Text.text = string.Format("{0:0}", seconds);
            task2Timer.fillAmount = Mathf.InverseLerp(1, holdingTimeForTask, timeForTask2); 
        }

        else 
        {
            taskTimer2Text.enabled = false;
            taskTimer2Text.gameObject.SetActive(false);

            task2Text.text = "2. ";
        }

        if (isTask3Active)
        {
            taskTimer3Text.enabled = true;
            taskTimer3Text.gameObject.SetActive(true);

            task3Text.text = "3. Get " + task3Item;

            if (timeForTask3 > 1)
            {
                timeForTask3 -= Time.deltaTime;
            }

            else
            {
                timeForTask3 = 0;
                taskTimer3Text.enabled = false;
                taskTimer3Text.gameObject.SetActive(false);

                task3Text.text = "3. ";

                if (hearts == 3)
                {
                    heart3.enabled = false;
                    heart3.gameObject.SetActive(false);

                    mesh.sharedMesh = middleBaby.sharedMesh;
                    Material[] newMaterials = new Material[middleBaby.sharedMaterials.Length];
                    
                    for (int i = 0; i < middleBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = middleBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;

                }

                else if (hearts == 2)
                {
                    heart2.enabled = false;
                    heart2.gameObject.SetActive(false);

                    mesh.sharedMesh = finalBaby.sharedMesh;
                    Material[] newMaterials = new Material[finalBaby.sharedMaterials.Length];

                    for (int i = 0; i < finalBaby.sharedMaterials.Length; i++)
                    {
                        newMaterials[i] = finalBaby.sharedMaterials[i];
                    }

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else 
                {
                    heart1.enabled = false;
                    heart1.gameObject.SetActive(false);
                    timer.gameOver = true;
                }

                hearts--;
                isTask3Active = false;
                timeForTask3 = holdingTimeForTask;
            }

            int seconds = Mathf.FloorToInt(timeForTask3 % 60);
            taskTimer3Text.text = string.Format("{0:0}", seconds); 
            task3Timer.fillAmount = Mathf.InverseLerp(1, holdingTimeForTask, timeForTask3);
        }

        else 
        {
            taskTimer3Text.enabled = false;
            taskTimer3Text.gameObject.SetActive(false);

            task3Text.text = "3. ";
        }

        if (timer.gameOver)
        {
            isTask1Active = false;
            isTask2Active = false;
            isTask3Active = false;
            CancelInvoke();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(isTask1Active && player.hasItem == true && player.heldItem == task1Item)
        {
            player.GiveItem();
            isTask1Active = false;

            timeForTask1 = holdingTimeForTask;
            taskTimer1Text.enabled = false;
            taskTimer1Text.gameObject.SetActive(false);

            task1Text.text = "1. ";
        }

        if(isTask2Active && player.hasItem == true && player.heldItem == task2Item)
        {
            player.GiveItem();
            isTask2Active = false;

            timeForTask2 = holdingTimeForTask;
            taskTimer2Text.enabled = false;
            taskTimer2Text.gameObject.SetActive(false);

            task2Text.text = "2. ";
        }

        if(isTask3Active && player.hasItem == true && player.heldItem == task3Item)
        {
            player.GiveItem();
            isTask3Active = false;

            timeForTask3 = holdingTimeForTask;
            taskTimer3Text.enabled = false;
            taskTimer3Text.gameObject.SetActive(false);

            task1Text.text = "3. ";
        }
    }

    void CreateTask()
    {
        if (!isTask1Active)
        {
            isTask1Active = true;

            random = Random.Range(1, itemNames.Count);

            task1Item = itemNames[random - 1];
        }

        else if (!isTask2Active)
        {
            isTask2Active = true;

            random = Random.Range(1, itemNames.Count);

            task2Item = itemNames[random - 1];
        }

        else if (!isTask3Active)
        {
            isTask3Active = true;

            random = Random.Range(1, itemNames.Count);

            task3Item = itemNames[random - 1];
        }
    }
}