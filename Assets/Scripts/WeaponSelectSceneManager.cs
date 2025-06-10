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
                break;
            case 1:
                WeaponText.text = "<color=red><b>OverClock</b></color>\n빠르게 대쉬를 해 옆의 적을 공격한다.";
                WeaponSelect.Instance.type = WeaponType.OverClock;
                break;
            case 2:
                WeaponText.text = "<color=red><b>Malware</b></color>\n강한 원거리 공격을 한다.";
                WeaponSelect.Instance.type = WeaponType.Malware;
                break;
            case 3:
                WeaponText.text = "<color=red><b>DDos</b></color>\n적에게 범위 스턴을 건다.";
                WeaponSelect.Instance.type = WeaponType.DDos;
                break;
        }
    }
}
