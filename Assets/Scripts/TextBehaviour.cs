using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour
{
    public PlayerController playerController;
    public ButtonHandler buttonHandler;
    public GameObject startButton;
    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonHandler.startGame)
        {
            PlayerStatus(playerController.playerDeath);
        }

        if (playerController.playerWin)
        {
            WinText();
        }

    }

    void PlayerStatus(bool playerDead)
    {
        Text displayText = this.gameObject.GetComponent<Text>();

        if (playerDead)
        {
            displayText.text = "You have died.";
            restartButton.SetActive(true);
        } else
        {
            displayText.text = " ";
            restartButton.SetActive(false);
        }
    }

    void WinText()
    {
        Text displayText = this.gameObject.GetComponent<Text>();
        displayText.text = "You Won!! Click to start again";
        restartButton.SetActive(true);
    }
}
