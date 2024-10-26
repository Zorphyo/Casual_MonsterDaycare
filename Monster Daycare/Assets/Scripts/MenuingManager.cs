using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuingManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject HowToPlayMenu;
    public GameObject ExtrasMenu;
    public GameObject LevelSelectMenu;
    public GameObject ShopMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        HowToPlayMenu.SetActive(false);
        ExtrasMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);
        ShopMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMain()
    {
        MainMenu.SetActive(true);
        HowToPlayMenu.SetActive(false);
        ExtrasMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);
        ShopMenu.SetActive(false);
    }
    public void LoadHowToPlay()
    {
        MainMenu.SetActive(false);
        HowToPlayMenu.SetActive(true);
        ExtrasMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);
        ShopMenu.SetActive(false);
    }
    public void LoadExtras()
    {
        MainMenu.SetActive(false);
        HowToPlayMenu.SetActive(false);
        ExtrasMenu.SetActive(true);
        LevelSelectMenu.SetActive(false);
        ShopMenu.SetActive(false);
    }
    public void LoadLevelSelect()
    {
        MainMenu.SetActive(false);
        HowToPlayMenu.SetActive(false);
        ExtrasMenu.SetActive(false);
        LevelSelectMenu.SetActive(true);
        ShopMenu.SetActive(false);
    }
    public void LoadShop()
    {
        MainMenu.SetActive(false);
        HowToPlayMenu.SetActive(false);
        ExtrasMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);
        ShopMenu.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
