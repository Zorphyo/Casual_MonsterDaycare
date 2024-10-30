using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public int price;
    public string shopItemName;

    [SerializeField] Button shopItemButton;
    [SerializeField] Button equipItemButton;

    // Start is called before the first frame update
    void Start()
    {
        shopItemButton.onClick.AddListener(() => BuyItem());
        equipItemButton.onClick.AddListener(() => EquipItem());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem()
    {
        Debug.Log("Bought " + shopItemName + " for " + price);
    }

    public void EquipItem()
    {
        Debug.Log("Equipped " + shopItemName);
    }
}
