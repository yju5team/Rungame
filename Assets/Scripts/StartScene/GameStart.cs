using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void GameStartButton()
    {
        LoadingSceneController.LoadScene("WeaponSelectScene");
    }

    public void ExitGame()
    {
        Application.Quit(0);
    }
}
