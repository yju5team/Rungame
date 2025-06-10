using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System;
using UnityEngine.UI;

#region Dataset
[Serializable]
public class Mode
{
    public scoreInfo FatalError;
    public scoreInfo OverClock;
    public scoreInfo Malware;
    public scoreInfo DDos;
}

[Serializable]
public class scoreInfo
{
    public int currentScore;
    public int BestScore;
    public int Level1Enemy;
    public int Level2Enemy;
    public int Level3Enemy;
}

#endregion

public class DataManager : MonoBehaviour
{
    #region Singleton
    private static DataManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static DataManager Instance
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

    void Start()
    {
        DataCreate();
    }

    void DataCreate()
    {
        if (!File.Exists(Path.Combine(Application.persistentDataPath, "ScoreData.json")))
        {
            string scoreDataFilePath = Path.Combine(Application.persistentDataPath, "ScoreData.json");
            string scorejsonText;

            TextAsset jsonFile = Resources.Load<TextAsset>("ScoreData");

            scorejsonText = jsonFile.text; // 읽어오고

            Mode mode = JsonUtility.FromJson<Mode>(scorejsonText);

            string changeScoreData = JsonUtility.ToJson(mode, true); // class를 string으로 바꾸고

            Debug.Log(changeScoreData);

            File.WriteAllText(scoreDataFilePath, changeScoreData); // string 값을 파일로 저장
        }
    }
    /// <summary>
    /// 스코어 데이터를 바꾸는 코드
    /// </summary>
    /// <param name="weaponType">무기 종류</param>
    /// <param name="curScore">현재 점수</param>
    /// <param name="L1">레벨1 몬스터 잡은 횟수</param>
    /// <param name="L2">레벨2 몬스터 잡은 횟수</param>
    /// <param name="L3">레벨3 몬스터 잡은 횟수</param>
    public void ScoreDataChange(WeaponType weaponType, int curScore, int L1, int L2, int L3)
    {
        string scoreDataFilePath = Path.Combine(Application.persistentDataPath, "ScoreData.json");
        var Data = ScoreDataLoad();
        var scoreData = weaponType switch
        {
            WeaponType.FatalError => Data.FatalError,
            WeaponType.OverClock => Data.OverClock,
            WeaponType.Malware => Data.Malware,
            WeaponType.DDos => Data.DDos,
            _ => null
        };

        if (scoreData == null) return;

        scoreData.currentScore = curScore;
        if (scoreData.BestScore < curScore)
        {
            scoreData.BestScore = curScore;
            scoreData.Level1Enemy = L1;
            scoreData.Level2Enemy = L2;
            scoreData.Level3Enemy = L3;
        }

        string changeScoreData = JsonUtility.ToJson(Data, true); // class를 string으로 바꾸고
        File.WriteAllText(scoreDataFilePath, changeScoreData);
    }


    public Mode ScoreDataLoad()
    {
        string scoreDataFilePath = Path.Combine(Application.persistentDataPath, "ScoreData.json");
        string scorejsonText = File.ReadAllText(scoreDataFilePath);

        Mode mode = JsonUtility.FromJson<Mode>(scorejsonText);

        return mode;
    }

    public scoreInfo DetailDataLoad(WeaponType weaponType)
    {
        var Data = ScoreDataLoad();

        return weaponType switch
        {
            WeaponType.FatalError => Data.FatalError,
            WeaponType.OverClock => Data.OverClock,
            WeaponType.Malware => Data.Malware,
            WeaponType.DDos => Data.DDos,
            _ => throw new ArgumentException("Invalid WeaponType", nameof(weaponType))
        };
    }
}
