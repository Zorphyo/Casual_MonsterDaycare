using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionEditor : MonoBehaviour
{
    public GameObject Description1;
    public GameObject Description2;
    public GameObject Description3;
    // Start is called before the first frame update
    void Start()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DescReveal1()
    {
        Description1.SetActive(true);
        Description2.SetActive(false);
        Description3.SetActive(false);
    }
    public void DescReveal2()
    {
        Description1.SetActive(false);
        Description2.SetActive(true);
        Description3.SetActive(false);
    }
    public void DescReveal3()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(true);
    }
}
