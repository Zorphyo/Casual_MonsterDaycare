using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyInteract : MonoBehaviour
{
    public Button Easy1;
    public Button Hard1;
    public Button Easy2;
    public Button Hard2;
    public Button Easy3;
    public Button Hard3;
    void Start()
    {
        Easy1.interactable = false;
        Hard1.interactable = false;
        Easy2.interactable = false;
        Hard2.interactable = false;
        Easy3.interactable = false;
        Hard3.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UnlockDifficulty1()
    {
        Easy1.interactable = true;
        Hard1.interactable = true;
        Easy2.interactable = false;
        Hard2.interactable = false;
        Easy3.interactable = false;
        Hard3.interactable = false;
    }
    public void UnlockDifficulty2()
    {
        Easy1.interactable = false;
        Hard1.interactable = false;
        Easy2.interactable = true;
        Hard2.interactable = true;
        Easy3.interactable = false;
        Hard3.interactable = false;
    }
    public void UnlockDifficulty3()
    {
        Easy1.interactable = false;
        Hard1.interactable = false;
        Easy2.interactable = false;
        Hard2.interactable = false;
        Easy3.interactable = true;
        Hard3.interactable = true;
    }
}
