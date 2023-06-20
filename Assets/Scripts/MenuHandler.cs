using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField playerNameEntry;
    public Button startButton;

    public void Start()
    {
        startButton.onClick.AddListener(GoToMain);

        playerNameEntry.onValueChanged.AddListener(delegate { SetPlayerName(); });
    }

    public void GoToMain()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerManager.Instance.playerName = playerNameEntry.text;
    }
}
