using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float speed;
    public string heldItem;
    //[SerializeField] Button itemButton;
    [SerializeField] TextMeshProUGUI inventoryText;
    [HideInInspector] public bool hasItem = false;

    float horizontal, vertical;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.gameOver)
        {
            audioSource.Stop();
        }
    }

    private void FixedUpdate()
    {
        horizontal = joystick.Horizontal * speed;
        vertical = joystick.Vertical * speed;

        transform.Translate(horizontal, 0, vertical);
    }

    public void GiveItem()
    {
        hasItem = false;
        //itemButton.interactable = true;

        inventoryText.text = "Inventory: ";

    }
}
