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
    [SerializeField] TextMeshProUGUI task1Text;
    [SerializeField] TextMeshProUGUI task2Text;
    [SerializeField] TextMeshProUGUI task3Text;

    SkinnedMeshRenderer mesh;
    [SerializeField] SkinnedMeshRenderer middleBaby;
    [SerializeField] SkinnedMeshRenderer finalBaby;

    float timeForTask;
    float holdingTimeForTask;
    [HideInInspector] public bool isTaskActive = false;
    public List<string> itemNames;

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
            timeForTask = 15.0f;
        }

        else 
        {
            minTime = 7;
            maxTime = 10;
            timeForTask = 10.0f;
        }

        holdingTimeForTask = timeForTask;

        random = Random.Range(minTime, maxTime);

        InvokeRepeating("CreateTask", 5.0f, random);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTaskActive)
        {
            taskTimer1Text.enabled = true;
            taskTimer1Text.gameObject.SetActive(true);

            task1Text.text = "1. Get " + itemNames[random - 1];

            if (timeForTask > 1)
            {
                timeForTask -= Time.deltaTime;
            }

            else
            {
                timeForTask = 0;
                taskTimer1Text.enabled = false;
                taskTimer1Text.gameObject.SetActive(false);

                task1Text.text = "1. ";

                if (hearts == 3)
                {
                    heart3.enabled = false;
                    heart3.gameObject.SetActive(false);

                    mesh.sharedMesh = middleBaby.sharedMesh;
                    //int counter = 0;

                    Material[] newMaterials = new Material[4];
                    newMaterials[0] = middleBaby.sharedMaterials[0];
                    newMaterials[1] = middleBaby.sharedMaterials[1];
                    newMaterials[2] = middleBaby.sharedMaterials[2];
                    newMaterials[3] = middleBaby.sharedMaterials[3];

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else if (hearts == 2)
                {
                    heart2.enabled = false;
                    heart2.gameObject.SetActive(false);

                    mesh.sharedMesh = finalBaby.sharedMesh;
                    //int counter2 = 0;
                    
                    Material[] newMaterials = new Material[4];
                    newMaterials[0] = finalBaby.sharedMaterials[0];
                    newMaterials[1] = finalBaby.sharedMaterials[1];
                    newMaterials[2] = finalBaby.sharedMaterials[2];
                    newMaterials[3] = finalBaby.sharedMaterials[3];

                    mesh.sharedMaterials = newMaterials;
                    
                }

                else 
                {
                    heart1.enabled = false;
                    heart1.gameObject.SetActive(false);
                    timer.gameOver = true;
                }

                hearts--;
                isTaskActive = false;
                timeForTask = holdingTimeForTask;
            }

            int seconds = Mathf.FloorToInt(timeForTask % 60);
            taskTimer1Text.text = string.Format("{0:0}", seconds); 
        }

        else 
        {
            taskTimer1Text.enabled = false;
            taskTimer1Text.gameObject.SetActive(false);

            task1Text.text = "1. ";
        }

        if (timer.gameOver)
        {
            isTaskActive = false;
            CancelInvoke();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(isTaskActive && player.hasItem == true && player.heldItem == itemNames[random - 1])
        {
            player.GiveItem();
            isTaskActive = false;

            timeForTask = holdingTimeForTask;
            taskTimer1Text.enabled = false;
            taskTimer1Text.gameObject.SetActive(false);

            task1Text.text = "1. ";
        }
    }

    void CreateTask()
    {
        if (!isTaskActive)
        {
            isTaskActive = true;

            random = Random.Range(1, itemNames.Count);
        }
    }
}
