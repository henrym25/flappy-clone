using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button startButton;
    public Button restartButton;
    public bool startGame = false;
    public bool restartGame = false;

    void Start()
    {
        Button sButton = startButton.GetComponent<Button>();
        sButton.onClick.AddListener(StartGame);

        Button rButton = restartButton.GetComponent<Button>();
        rButton.onClick.AddListener(RestartGame);
    }

    void StartGame()
    {
        startGame = true;
        startButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
}
