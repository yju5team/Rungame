using System.Collections;
using System.Collections.Generic;
using GridScene;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Weapon equippedWeapon; // 장착된 무기

    private MovementScript movementScript;

    private void Awake()
    {
        movementScript = GetComponent<MovementScript>();
    }

    private void Start()
    {
        equippedWeapon = GetComponent<Weapon>();
        //equippedWeapon.weaponType = WeaponType.Malware;

    }

    private void Update()
    {
        Attack();
        Movement();

        //Debug.Log("Current Rotation: " + transform.rotation.eulerAngles.z);

    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        if (x != 0 || y != 0)
        {
            if (x == 0 && y != 0 || x != 0 && y == 0)
            {
                movementScript.MoveDirection = new Vector3(x, y, 0);
                float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, 0, angle);
            }

        }
        else
        {
            movementScript.MoveDirection = Vector3.zero;
        }
    }


    void Attack()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !GameManager.Instance.GameEnd)
        {
            Debug.Log("Mouse clicked!");

            equippedWeapon.Attack();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
