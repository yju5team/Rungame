using System.Collections;
using System.Collections.Generic;
using GridScene;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponType weaponType;

    public GameObject Boomerang;
    public Animator animator;

    void Awake()
    {
        weaponType = WeaponSelect.Instance.type;
    }


    public void Attack()
    {
        switch (weaponType)
        {
            case WeaponType.FatalError:
                Debug.Log("Fatal Error! 근접 공격");
                animator.SetTrigger("FatalError");
                break;

            case WeaponType.OverClock:
                Debug.Log("OverClock! 대쉬기");
                GameManager.Instance.Player.GetComponent<MovementScript>().OverClockDash();
                break;

            case WeaponType.Malware:
                Debug.Log("Malware! 부메랑");
                var bo = Instantiate(Boomerang, transform.position, transform.rotation);
                bo.GetComponent<Boomerang>().Throw(transform.right);
                break;

            case WeaponType.DDos:
                Debug.Log("DDOS! cc기");
                animator.SetTrigger("DDos");
                break;

            default:
                Debug.Log("알수없음");
                break;
        }
    }
}