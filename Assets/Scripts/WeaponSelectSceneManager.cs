using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WeaponSelectSceneManager : MonoBehaviour
{
    [SerializeField]
    private int index;
    [Header("UI")]
    public Image WeaponImage;
    public TextMeshProUGUI WeaponText;

    public TextMeshProUGUI BestButtonText;
    public GameObject BestInfoPanel;
    public TextMeshProUGUI BestPanelText;
    public TextMeshProUGUI RunScoreText;
    public TextMeshProUGUI LV1ScoreText;
    public TextMeshProUGUI LV2ScoreText;
    public TextMeshProUGUI LV3ScoreText;



    private WeaponType weaponType;

    void Awake()
    {
        weaponType = WeaponSelect.Instance.type;
        switch (weaponType)
        {
            case WeaponType.FatalError:
                index = 0;
                break;
            case WeaponType.OverClock:
                index = 1;
                break;
            case WeaponType.Malware:
                index = 2;
                break;
            case WeaponType.DDos:
                index = 3;
                break;
            default:
                index = 0;
                break;
        }
        WeaponReset();
    }

    void Start()
    {
        BestInfoActiver(false);
    }

    void Update()
    {
        //0,1,2,3
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && index > 0)
        {
            WeaponIndexChanger(false);
        }
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && index < 3)
        {
            WeaponIndexChanger(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GridGame");
        }
    }

    public void WeaponIndexChanger(bool result)
    {
        if (result) // ++
        {
            if (index < 3)
                index++;
        }
        else // --
        {
            if (index > 0)
                index--;
        }
        WeaponReset();
    }

    void WeaponReset()
    {
        //WeaponImage = ;
        switch (index)
        {
            case 0:
                WeaponText.text = "<color=red><b>Fatal Error</b></color>\n강한 근접 공격을 한다.";
                WeaponSelect.Instance.type = WeaponType.FatalError;
                BestButtonText.text = $"BEST : {DataManager.Instance.DetailDataLoad(WeaponType.FatalError).BestScore}";
                break;
            case 1:
                WeaponText.text = "<color=red><b>OverClock</b></color>\n빠르게 대쉬를 해 옆의 적을 공격한다.";
                WeaponSelect.Instance.type = WeaponType.OverClock;
                BestButtonText.text = $"BEST : {DataManager.Instance.DetailDataLoad(WeaponType.OverClock).BestScore}";
                break;
            case 2:
                WeaponText.text = "<color=red><b>Malware</b></color>\n강한 원거리 공격을 한다.";
                WeaponSelect.Instance.type = WeaponType.Malware;
                BestButtonText.text = $"BEST : {DataManager.Instance.DetailDataLoad(WeaponType.Malware).BestScore}";
                break;
            case 3:
                WeaponText.text = "<color=red><b>DDos</b></color>\n적에게 범위 스턴을 건다.";
                WeaponSelect.Instance.type = WeaponType.DDos;
                BestButtonText.text = $"BEST : {DataManager.Instance.DetailDataLoad(WeaponType.DDos).BestScore}";
                break;
        }
    }

    public void BestInfoActive()
    {
        var data = DataManager.Instance.DetailDataLoad(WeaponSelect.Instance.type);
        BestPanelText.text = $"BEST : {data.BestScore}";
        RunScoreText.text = $"RUN SCORE : {data.BestScore - data.Level1Enemy - data.Level2Enemy - data.Level3Enemy}";
        LV1ScoreText.text = $"Level 1 Vaccine Score : {data.Level1Enemy}";
        LV2ScoreText.text = $"Level 2 Vaccine Score : {data.Level2Enemy}";
        LV3ScoreText.text = $"Level 3 Vaccine Score : {data.Level3Enemy}";

        BestInfoActiver(true);
    }

    public void BestInfoActiver(bool isActive)
    {
        BestInfoPanel.SetActive(isActive);
    }
}
