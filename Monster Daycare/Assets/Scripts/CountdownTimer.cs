using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownText;

    IEnumerator CountDownToStart()
    {
        while(countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownText.text = "Go!";

        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);

        GameManager.gameStarted = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownToStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}