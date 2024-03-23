using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class StartUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlayerNameInput;
    // Start is called before the first frame update
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.playerName = PlayerNameInput.text;
    }
}
