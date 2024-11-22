using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public int price;
    public string shopItemName;
    public int isPurchased;
    public int isEquipped;

    AudioSource audioSource;
    public AudioClip purchasedSound;

    [SerializeField] Button shopItemButton;
    [SerializeField] Button equipItemButton;
    [SerializeField] TextMeshProUGUI priceText;
    [SerializeField] TextMeshProUGUI purchasedText;
    [SerializeField] TextMeshProUGUI equippedText;

    // Start is called before the first frame update
    void Start()
    {

        shopItemButton.onClick.AddListener(() => BuyItem());
        equipItemButton.onClick.AddListener(() => EquipItem());
        priceText.text = price.ToString();

        //PlayerPrefs.SetInt(shopItemName + " Purchased", 0);
        //PlayerPrefs.SetInt(shopItemName + " Equipped", 0);

        isPurchased = PlayerPrefs.GetInt(shopItemName + " Purchased", 0);
        isEquipped = PlayerPrefs.GetInt(shopItemName + " Equipped", 0);

        equippedText.text = "";
        purchasedText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem()
    {

        if (CurrencyManager.playerCurrency >= price && isPurchased == 0)
        {
            Debug.Log("Bought " + shopItemName + " for " + price);

            CurrencyManager.playerCurrency -= price;
            PlayerPrefs.SetInt("Currency", CurrencyManager.playerCurrency);

            isPurchased = 1;
            PlayerPrefs.SetInt(shopItemName + " Purchased", isPurchased);

            purchasedText.text = "Purchased!";
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(purchasedSound);
        }

        else if (CurrencyManager.playerCurrency < price && isPurchased == 0)
        {
            purchasedText.text = "Not Enough Funds!";
        }

        else
        {
            Debug.Log("Already Purchased or Not Enough Funds");
            purchasedText.text = "Already Purchased!";
        }
    }

    public void EquipItem()
    {
        if (isPurchased == 1 && isEquipped == 0)
        {
            Debug.Log("Equipped " + shopItemName);

            isEquipped = 1;
            PlayerPrefs.SetInt(shopItemName + " Equipped", isEquipped);
            equippedText.text = "Equipped!";
        }

        else if (isPurchased == 1 && isEquipped == 1)
        {
            isEquipped = 0;
            PlayerPrefs.SetInt(shopItemName + " Equipped", isEquipped);
            Debug.Log("Unequipped or Not Purchased");
            equippedText.text = "Unequipped!";
        }

        else
        {
            equippedText.text = "Not Purchased!";
        }
    }
}
