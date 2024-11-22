using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    public string itemName;
    [SerializeField] Button itemButton;
    [SerializeField] TextMeshProUGUI inventoryText;

    private PlayerMovement player;

    AudioSource audioSource;
    Outline outline;

    void Awake()
    {
        itemButton.onClick.AddListener(() => PickUpItem(itemName));
    }

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        audioSource = GetComponent<AudioSource>();

        outline = gameObject.AddComponent<Outline>();
        outline.enabled = false;
        outline.OutlineColor = Color.white;
        outline.OutlineWidth = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        ShowButton();
        outline.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        HideButton();
        outline.enabled = false;
    }

    public void ShowButton()
    {
        itemButton.enabled = true;
        itemButton.gameObject.SetActive(true);
    }

    public void HideButton()
    {
        itemButton.enabled = false;
        itemButton.gameObject.SetActive(false);
    }

    public void PickUpItem(string itemName)
    {
        player.hasItem = true;
        player.heldItem = itemName;

        inventoryText.text = "Inventory: " + itemName;

        audioSource.Play();
    }
}
