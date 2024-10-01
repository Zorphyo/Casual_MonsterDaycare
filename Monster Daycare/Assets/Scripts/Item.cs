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

    void Awake()
    {
        itemButton.onClick.AddListener(() => PickUpItem(itemName));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        player = other.GetComponent<PlayerMovement>();

        ShowButton();
    }

    void OnTriggerExit(Collider other)
    {
        player = other.GetComponent<PlayerMovement>();

        HideButton();
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
        itemButton.interactable = false;

        inventoryText.text = inventoryText.text + itemName;
    }
}
