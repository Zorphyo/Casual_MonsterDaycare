using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public static int playerCurrency = 0;
    public TextMeshProUGUI currencyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = playerCurrency.ToString();
    }
}
