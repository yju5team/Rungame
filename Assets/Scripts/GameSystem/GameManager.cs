using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region singleton
    private static GameManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    #endregion
    public int score;

    public GameObject Player;

    private bool isgameEnd;
    public bool GameEnd
    {
        get { return isgameEnd; }
    }

    // Start is called before the first frame update
    void Start() //초기화
    {
        isgameEnd = false;
        UIManager.Instance.GameOverPanelActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isgameEnd == true && Input.GetKeyDown(KeyCode.Space))
        {
            GameRestart();
        }
    }


    // void StartTimeScore()
    // {
    //     StartCoroutine(TimeScore());
    // }

    // private IEnumerator TimeScore()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(0.1f);
    //         score += 1;
    //     }
    // }

    public void GameOver()
    {
        isgameEnd = true;
        Time.timeScale = 0;
        UIManager.Instance.GameOverPanelActive(true);
    }

    public void GameRestart()
    {
        isgameEnd = false;
        UIManager.Instance.GameOverPanelActive(false);
        Time.timeScale = 1;
        score = 0;
        SceneManager.LoadScene("WeaponSelectScene");
    }
}
