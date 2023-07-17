using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour
{
    public bool gameStarted = false;
    public PlayerController deathHappened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            PlayerStatus(deathHappened.playerDeath);
        }

    }

    public void OnStartClicked()
    {
        gameStarted = true;
        GameObject startButton = GameObject.Find("Start Button");
        startButton.SetActive(false);
    }


    void PlayerStatus(bool playerDead)
    {
        Text displayText = this.gameObject.GetComponent<Text>();

        if (playerDead)
        {
            displayText.text = "You have died.";
        } else
        {
            displayText.text = " ";
        }
    }
}
