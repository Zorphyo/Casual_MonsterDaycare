using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        player = other.GetComponent<PlayerMovement>();

        player.ShowButton();
    }

    void OnTriggerExit(Collider other)
    {
        player = other.GetComponent<PlayerMovement>();

        player.HideButton();
    }
}
