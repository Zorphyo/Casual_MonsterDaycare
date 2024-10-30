using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public static int playerCurrency;
    public TextMeshProUGUI currencyText;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Currency", 0);
        playerCurrency = PlayerPrefs.GetInt("Currency", 0);
        Debug.Log(PlayerPrefs.GetInt("Currency"));
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = playerCurrency.ToString();
    }
}
