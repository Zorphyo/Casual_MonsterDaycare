using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionEditor : MonoBehaviour
{
    public TMP_Text Description1;
    public TMP_Text Description2;
    public TMP_Text Description3;
    // Start is called before the first frame update
    void Start()
    {
        Description1.enabled = false;
        Description2.enabled = false;
        Description3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DescReveal1()
    {
        Description1.enabled = true;
        Description2.enabled = false;
        Description3.enabled = false;
    }
    public void DescReveal2()
    {
        Description1.enabled = false;
        Description2.enabled = true;
        Description3.enabled = false;
    }
    public void DescReveal3()
    {
        Description1.enabled = false;
        Description2.enabled = false;
        Description3.enabled = true;
    }
}
