using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class backGroundScroll : MonoBehaviour

{
    private MeshRenderer render;

    public float speed;
    private float offset;

    void Start()
    {
        StartCoroutine(speedlimit());
        render = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
    }
    IEnumerator speedlimit()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            if (speed < 1.5)
            {
                speed += 0.01f;
            }
            else
            {
                break;
            }
        }
    }
}
