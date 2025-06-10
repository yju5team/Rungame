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

    [Header("GameOverText")]
    public TextMeshProUGUI CurScoreText;
    public TextMeshProUGUI BestScoreText;
    public TextMeshProUGUI RunTimeText;
    public TextMeshProUGUI Vaccinne1Text;
    public TextMeshProUGUI Vaccinne2Text;
    public TextMeshProUGUI Vaccinne3Text;

    void Update()
    {
        scoreText.text = ScoreManager.Instance.score.ToString();
    }

    public void UpdateGameOverText()
    {
        var scoreManager = ScoreManager.Instance;
        CurScoreText.text = $"SCORE : {scoreManager.score}";
        BestScoreText.text = $"BEST : " + (DataManager.Instance.DetailDataLoad(WeaponSelect.Instance.type).BestScore > scoreManager.score ? DataManager.Instance.DetailDataLoad(WeaponSelect.Instance.type).BestScore : "New");
        RunTimeText.text = $"RUN TIME : {FormatTime(scoreManager.curTime)} \n(score : {scoreManager.score - scoreManager.levelEnemy[0] * 100 - scoreManager.levelEnemy[1] * 200 - scoreManager.levelEnemy[2] * 300})";
        Vaccinne1Text.text = $"Level 1 Vaccine Eliminations : {scoreManager.levelEnemy[0]} \n(score : {scoreManager.levelEnemy[0] * 100})";
        Vaccinne2Text.text = $"Level 2 Vaccine Eliminations : {scoreManager.levelEnemy[1]} \n(score : {scoreManager.levelEnemy[1] * 200})";
        Vaccinne3Text.text = $"Level 3 Vaccine Eliminations : {scoreManager.levelEnemy[2]} \n(score : {scoreManager.levelEnemy[2] * 300})";

        DataManager.Instance.ScoreDataChange(WeaponSelect.Instance.type, scoreManager.score, scoreManager.levelEnemy[0], scoreManager.levelEnemy[1], scoreManager.levelEnemy[2]);
        GameOverPanelActive(true);
    }

    public void GameOverPanelActive(bool Active)
    {
        GameOverPanel.SetActive(Active);
    }

    string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        float seconds = time % 60;

        return minutes > 0 ? $"{minutes}:{seconds:F1}" : $"{seconds:F1}";
    }

}


