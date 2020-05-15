using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer[] Pinguins;

    public int currentPinguin;
    public bool State = true;
    // Start is called before the first frame update
    void Start()
    {
        currentPinguin = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && currentPinguin > 1)
        {
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 0.1f);
            currentPinguin -= 1;
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 1f);
        }
        else if (Input.GetKeyDown(KeyCode.D) && currentPinguin < 5)
        {
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 0.1f);
            currentPinguin += 1;
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 1f);
        }
    }
    void Controller(string command) {
        if (command == "Left" && currentPinguin > 1)
        {
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 0.1f);
            currentPinguin -= 1;
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 1f);
        }
        else if (command == "Right" && currentPinguin < 5)
        {
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 0.1f);
            currentPinguin += 1;
            Pinguins[currentPinguin - 1].color = new Color (1f, 1f, 1f, 1f);
        }
    }
}
