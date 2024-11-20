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

    Rigidbody rb;
    AudioSource audioSource;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.gameOver)
        {
            audioSource.Stop();
        }

        if (horizontal != 0 || vertical != 0)
        {
            audioSource.enabled = true;
            animator.SetBool("isMoving", true);
        }

        else 
        {
            audioSource.enabled = false;
            animator.SetBool("isMoving", false);
        }
    }

    private void FixedUpdate()
    {
        horizontal = joystick.Horizontal * speed;
        vertical = joystick.Vertical * speed;

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical).normalized;

        rb.velocity = new Vector3(horizontal, 0, vertical);

        if (movementDirection == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
        targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360 * Time.fixedDeltaTime);
        rb.MoveRotation(targetRotation);
    }

    public void GiveItem()
    {
        hasItem = false;

        inventoryText.text = "Inventory: ";

    }
}
