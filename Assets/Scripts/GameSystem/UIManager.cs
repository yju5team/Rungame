using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region singleton
    private static UIManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
    }
    public static UIManager Instance
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
    [Header("UI_Obj")]
    public GameObject GameOverPanel;

    [Header("Text")]
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = GameManager.Instance.score.ToString();
    }

    public void GameOverPanelActive(bool Active)
    {
        GameOverPanel.SetActive(Active);
    }
}


