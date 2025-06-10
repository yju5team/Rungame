using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float HP = 100f;
    public int Level = 1;
    public float movementSpeed = 5f;

    // Start is called before the first frame update
    void OnEnable()
    {
        HP = 100f * Level;
        movementSpeed = 5f;
        StartCoroutine(ReturnObj());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);

        if (HP <= 0.1f)
        {
            ObjectDestroy();
        }
    }

    IEnumerator ReturnObj()
    {
        yield return new WaitForSeconds(10f);
        ObjectDestroy();
    }

    void ObjectDestroy()
    {
        ScoreManager.Instance.EnemyDeath(Level);
        EnemyPool.ReturnObject(this);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            HP -= other.gameObject.GetComponent<Damage>().damageValue;
        }

        if (other.gameObject.CompareTag("DDos"))
        {
            transform.position = new Vector2(transform.position.x + 5f, transform.position.y);
            var moveSpeed = movementSpeed;
            movementSpeed = 1f;
            StartCoroutine(DDos(moveSpeed));
            HP -= other.gameObject.GetComponent<Damage>().damageValue;
        }
    }

    IEnumerator DDos(float Speed)
    {
        yield return new WaitForSeconds(0.8f);
        movementSpeed = Speed;
    }


}
