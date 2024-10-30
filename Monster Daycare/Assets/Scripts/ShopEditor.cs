using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopEditor : MonoBehaviour
{
    public GameObject Description1;
    public GameObject Description2;
    public GameObject Description3;
    public GameObject Description4;
    public GameObject Description5;

    // Start is called before the first frame update
    void Start()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(false);
        Description4.SetActive(false);
        Description5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShopDescReveal1()
    {
        Description1.SetActive(true);
        Description2.SetActive(false);
        Description3.SetActive(false);
        Description4.SetActive(false);
        Description5.SetActive(false);
    }
    public void ShopDescReveal2()
    {
        Description1.SetActive(false);
        Description2.SetActive(true);
        Description3.SetActive(false);
        Description4.SetActive(false);
        Description5.SetActive(false);
    }
    public void ShopDescReveal3()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(true);
        Description4.SetActive(false);
        Description5.SetActive(false);
    }
    public void ShopDescReveal4()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(false);
        Description4.SetActive(true);
        Description5.SetActive(false);
    }
    public void ShopDescReveal5()
    {
        Description1.SetActive(false);
        Description2.SetActive(false);
        Description3.SetActive(false);
        Description4.SetActive(false);
        Description5.SetActive(true);
    }
}